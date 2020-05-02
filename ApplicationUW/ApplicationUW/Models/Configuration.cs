using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUW.Models
{
    public class Configuration
    {
        [DisplayName("Shtegu i ontologjise Instagram")]
        [Required(ErrorMessage ="Kjo fushë obligative")]
        public string InstagramPath { get; set; }

        [DisplayName("Shtegu i ontologjise My Heritage")]
        [Required(ErrorMessage = "Kjo fushë obligative")]
        public string MyHeritagePath { get; set; }
    }
}
