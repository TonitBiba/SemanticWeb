using ApplicationUW.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VDS.RDF;
using VDS.RDF.Query;
using VDS.RDF.Shacl.Validation;

namespace ApplicationUW.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult _Index(QueryOntology queryOntology)
        {
            IGraph g = new Graph();

            StreamReader file = new StreamReader("Config.json");
            JsonSerializer serializer = new JsonSerializer();
            var configurations = JsonConvert.DeserializeObject<Configuration>(file.ReadToEnd());

            if (queryOntology.Ontology == 1)
                g.LoadFromFile(configurations.InstagramPath);
            else
                g.LoadFromFile(configurations.MyHeritagePath);

            try
            {
                Object results = g.ExecuteQuery(queryOntology.Query);
                //Object results = g.ExecuteQuery( "SELECT DISTINCT ?Concept WHERE {[] a ?Concept}");
                if (results is SparqlResultSet)
                {
                    SparqlResultSet rset = (SparqlResultSet)results;
                    string value = rset.Results.ElementAt(0).ToString();
                    
                    ResultQueryList rql = new ResultQueryList();
                    rql.Columns = new List<string>();
                    rql.Rows = new List<string>();
                    int NumberOfColumns = rset.Results[0].Count();

                    for(int i=0;i<NumberOfColumns;i++)
                    {
                        rql.Columns.Add(rset.Results[0].ElementAt(i).Key.ToString());
                    }

                    for(int i=0;i<rset.Results.Count();i++)
                    {
                        for(int j=0;j<rset.Results.ElementAt(i).Count();j++)
                        {
                            rql.Rows.Add(rset.Results[i].ElementAt(j).Value == null ? "": rset.Results[i].ElementAt(j).Value.ToString());
                        }
                    }
                    
                    return PartialView(rql);

                }
                else if (results is IGraph)
                {
                    IGraph resGraph = (IGraph)results;
                    var result = resGraph.Triples.Select(s => new ResultQueryList
                    {
                        Object = s.Object.ToString(),
                        Predicate = s.Predicate.ToString(),
                        Subject = s.Subject.ToString()
                    });
                    return PartialView(result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            catch (RdfQueryException queryEx)
            {
                Console.WriteLine(queryEx.Message);
            }
            return PartialView();
        }

        [HttpGet]
        public IActionResult Configuration()
        {
            using (StreamReader file = new StreamReader("Config.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                var configurations = JsonConvert.DeserializeObject<Configuration>(file.ReadToEnd());
                return View(configurations);
            }
        }

        [HttpPost]
        public IActionResult Configuration(Configuration config)
        {
            try
            {
                using (StreamReader file = new StreamReader("Config.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var configurations = JsonConvert.DeserializeObject<Configuration>(file.ReadToEnd());
                    configurations.InstagramPath = config.InstagramPath;
                    configurations.MyHeritagePath = config.MyHeritagePath;

                    file.Close();

                    using (TextWriter filet = new StreamWriter("Config.json"))
                    {
                        serializer.Serialize(filet, configurations);
                    }

                    ViewBag.Error = new ErrorMessage { ErrorNumber = 1, ErrorDescription = "Te dhenat jane ruajtur me sukses!" };
                    return View(configurations);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = new ErrorMessage { ErrorNumber = 4, ErrorDescription = "Ka ndodhur nje gabim gjate ruajtjes. Provoni përsëri. " + ex.ToString() };
                return View(config);
            }
        }

        public ActionResult ExecuteSparql()
        {
            return View();
        }

        public JsonResult _ExecuteSPARQL(string dataSet, string Query)
        {
            IGraph g = new Graph();
            g.LoadFromFile(dataSet);
            try
            {
                Object results = g.ExecuteQuery(Query);
                if (results is SparqlResultSet)
                {
                    SparqlResultSet rset = (SparqlResultSet)results;
                    var result = rset.Select(s => new ResultQueryList
                    {
                        Object = s.ToString(),
                        Predicate = s.ToString(),
                        Subject = s.ToString()
                    });
                    return Json(JsonConvert.SerializeObject(rset));
                }
                else if (results is IGraph)
                {
                    IGraph resGraph = (IGraph)results;
                    return Json(resGraph.Triples);
                }
                else
                    return Json(false);
            }
            catch (RdfQueryException queryEx)
            {
                return Json(queryEx);
            }
        }
    }
}