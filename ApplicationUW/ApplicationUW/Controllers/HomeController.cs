using ApplicationUW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Query.Builder;

namespace ApplicationUW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(QueryOntology queryOntology)
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
                    foreach (SparqlResult r in rset)
                    {
                    }
                }
                else if (results is IGraph)
                {
                    IGraph resGraph = (IGraph)results;
                    foreach (Triple t in resGraph.Triples)
                    {
                        //Do whatever you want with each Triple
                    }
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
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
                return View(configurations);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
