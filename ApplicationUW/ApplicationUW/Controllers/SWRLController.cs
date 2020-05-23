using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ApplicationUW.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Configuration = ApplicationUW.Models.Configuration;

namespace ApplicationUW.Controllers
{
    public class SWRLController : Controller
    {
        private byte[] bytes = new byte[1024];
        private IPHostEntry ipHostInfo;
        private IPAddress ipAddress;
        private IPEndPoint remoteEP;
        private Socket sender;
        private Configuration configurations;


        public SWRLController()
        {
            ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            ipAddress = ipHostInfo.AddressList[0];
            remoteEP = new IPEndPoint(ipAddress, 5550);
            sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            StreamReader file = new StreamReader("Config.json");
            JsonSerializer serializer = new JsonSerializer();
            configurations = JsonConvert.DeserializeObject<Configuration>(file.ReadToEnd());
        }


        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult _Index(QueryOntology queryOntology)
        {
            List<string> queryResult = new List<string>();
            string result = "";
            int bytesRec = 0;

            string ontologyPath = "";
            if (queryOntology.Ontology == 1)
                ontologyPath = configurations.InstagramPath;
            else
                ontologyPath = configurations.MyHeritagePath;

            try
            {
                sender.Connect(remoteEP);
                var objectToSend = JsonConvert.SerializeObject(new { path = ontologyPath, query = queryOntology.Query });

                byte[] msg = Encoding.ASCII.GetBytes(objectToSend + "\n");
                int bytesSent = sender.Send(msg);

                while ((bytesRec = sender.Receive(bytes)) > 0)
                {
                    result = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (result == "\n")
                        break;
                    queryResult.Add(result);
                }

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            return PartialView(queryResult);
        }
    }
}