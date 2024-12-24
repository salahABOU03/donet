using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Livre
    {
        [Key]
        public int id_l { get; set; }
        public string? titre_l { get; set; }
        public string? resume_l { get; set; }
        [ForeignKey("Auteur")]
        public int? id_auteur { get; set; }
        public byte[]? fichier { get; set; }
        public string? images { get; set; }
        


        public string? genre { get; set; }
        public string? type { get; set; }
        public DateTime annee_l { get; set; }
       
    }
}