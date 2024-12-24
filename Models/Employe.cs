using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Employe
    {

        [Key]
        public int id_employe { get; set; }
        public string? nom_employe { get; set; }
        public string? prenom_e { get; set; }
        public string? email { get; set; }
        public string? telephone { get; set; }
        public string? adresse { get; set; }
        public string? Logine { get; set; }
        
        public string? Passworde { get; set; }

    }
}
