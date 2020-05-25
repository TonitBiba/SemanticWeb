using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUW.Models
{
    public class DemoModel
    {
        [DisplayName("Shtegu i fajllit html")]
        [Required]
        public string Path { get; set; }

        [DisplayName("Përmbajtja e html fajllit")]
        public string Data { get; set; }

        public string Property { get; set; }
        public string Value { get; set; }
        public string InnerHTML { get; set; }

        public List<DemoModel> ProcessedData;
    }
}
