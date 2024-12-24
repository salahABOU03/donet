using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.Models
{
    public class Pays
    {
        [Key]
        public int id_p { get; set; }
        public string? nom_p { get; set; }
    }
}
