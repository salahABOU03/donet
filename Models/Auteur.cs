using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library.Models
{
    public class Auteur
    {

        [Key]
        public int id_a { get; set; }
        public string? nom_a { get; set; }
        public string? prenom_a { get; set; }
        public DateTime date_naissance { get; set; }
        [ForeignKey("Pays")]
        public int? id_p { get; set; }
       
       

    }
}
