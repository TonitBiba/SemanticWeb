using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ApplicationUW.Models
{
    public class QueryOntology
    {
        [DisplayName("Ontologjia")]
        [Required(ErrorMessage = "Kjo fushë obligative")]
        public int Ontology { get; set; }

        [DisplayName("Pyetësori")]
        [Required(ErrorMessage = "Kjo fushë obligative")]
        public string Query { get; set; }
    }
}
