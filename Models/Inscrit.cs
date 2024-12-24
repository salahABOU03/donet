using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library.Models
{
    public class Inscrit
    {
        [Key]
        public int id_I { get; set; }

        public string? nom_i { get; set; }

        public string? prenom_i { get; set; }
        public DateTime? date_naissance { get; set; }

        public string? ville { get; set; }
        public string? email { get; set; }
        public string? telephone { get; set; }

        public string? Logine { get; set; }
        public string? Passworde { get; set; }

    }
}
