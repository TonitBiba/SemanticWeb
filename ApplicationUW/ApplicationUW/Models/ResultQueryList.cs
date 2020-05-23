using System.Collections.Generic;

namespace ApplicationUW.Models
{
    public class ResultQueryList
    {
        public string Subject { get; set; }

        public string Predicate { get; set; }

        public string Object { get; set; }

        public List<string> Columns;
        public List<string> Rows;

    }
}
