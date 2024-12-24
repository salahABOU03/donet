using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Confirmation
    {

        [Key]
        public int id_confirmation { get; set; }
        public DateTime date_confirmation { get; set; }
        public string? status_confirmation { get; set; }
       
        [ForeignKey("Emprunt")]
        public int? id_emprunt { get; set; }
        [ForeignKey("Employe")]
        public int? id_employe { get; set; }

    }
}
