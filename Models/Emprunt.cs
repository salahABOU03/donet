using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Emprunt
    {
        [Key]
        public int id_emp{ get; set; }
        public DateTime date_emprunt { get; set; }
        public DateTime date_delai { get; set; }

        [ForeignKey("Inscrit")]
        public int? id_inscrit { get; set; }
        [ForeignKey("Livre")]
        public int? id_l { get; set; }
    }
}
