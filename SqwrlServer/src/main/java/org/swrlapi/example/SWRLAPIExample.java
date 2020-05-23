package org.swrlapi.example;

import org.checkerframework.checker.nullness.qual.NonNull;
import org.semanticweb.owlapi.apibinding.OWLManager;
import org.semanticweb.owlapi.model.OWLOntology;
import org.semanticweb.owlapi.model.OWLOntologyCreationException;
import org.semanticweb.owlapi.model.OWLOntologyManager;
import org.swrlapi.factory.SWRLAPIFactory;
import org.swrlapi.parser.SWRLParseException;
import org.swrlapi.sqwrl.SQWRLQueryEngine;
import org.swrlapi.sqwrl.SQWRLResult;
import org.swrlapi.sqwrl.exceptions.SQWRLException;
import org.swrlapi.sqwrl.values.SQWRLResultValue;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.List;
import java.util.Optional;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;


public class SWRLAPIExample
{
   private Socket          socket   = null; 
   private ServerSocket    server   = null; 
   private DataOutputStream out     = null; 
   
   public SWRLAPIExample(int port) {
       try
       { 
           server = new ServerSocket(port); 
           System.out.println("SWRL Server started"); 

    	   while(true) {
 
           socket = server.accept(); 

           BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));

           out    = new DataOutputStream(socket.getOutputStream()); 

           String message = in.readLine();
           System.out.println(message);
           Gson gson = new GsonBuilder().create();
           SwrlModel swrlModel = gson.fromJson(message, SwrlModel.class);
           
     	   SQWRLResult result = ExecuteSQWRL(swrlModel.getQuery(), swrlModel.getPath());
     	   
 		   try {     	   
 			   while(result.next()) {
 				   List<SQWRLResultValue> rowResult = result.getRow();
 		           out.write(rowResult.toString().getBytes());
 			   }	
			} catch (SQWRLException e) {
				e.printStackTrace();
			}
     	   
	       out.write("\n".getBytes());

           out.flush();
           
           socket.close(); 
           in.close(); 
    	   }
       } 
       catch(IOException i) 
       { 
           System.out.println(i); 
       }  
   
   }
   
   
   
  public static void main(String[] args)
  {
	  SWRLAPIExample server = new SWRLAPIExample(5550); 

	  //SQWRLResult test = ExecuteSQWRL("Chat(?chat) ^ hasSender(?chat, ?account) ^ DateMesage(?chat, ?message) ^ temporal:after(?message, \"2020-01-02T21:33:00\"^^xsd:dateTime) -> sqwrl:select(?account) ^ sqwrl:count(?account) ^ sqwrl:orderByDescending(?account) ^ sqwrl:limit(2) ^ sqwrl:columnNames(\"Account\", \"Total message send\")", owlFilename);

  }
  
  public static SQWRLResult ExecuteSQWRL(String query, String OntologyPath) {	    
	    try 
	    {
	      File owlFile = new File(OntologyPath);
	      OWLOntologyManager ontologyManager = OWLManager.createOWLOntologyManager();
	      OWLOntology ontology = ontologyManager.loadOntologyFromOntologyDocument(owlFile);

	      SQWRLQueryEngine queryEngine = SWRLAPIFactory.createSQWRLQueryEngine(ontology);

	      SQWRLResult result = queryEngine.runSQWRLQuery("query", query);
	      
	      return result; 
	      
	    } catch (OWLOntologyCreationException e) {
	      System.err.println("Error creating OWL ontology: " + e.getMessage());
	      System.exit(-1);
	    } catch (SWRLParseException e) {
	      System.err.println("Error parsing SWRL rule or SQWRL query: " + e.getMessage());
	      System.exit(-1);
	    } catch (SQWRLException e) {
	      System.err.println("Error running SWRL rule or SQWRL query: " + e.getMessage());
	      System.exit(-1);
	    } catch (RuntimeException e) {
	      System.err.println("Error starting application: " + e.getMessage());
	      System.exit(-1);
	    }
	  return null;
  }
  
}
