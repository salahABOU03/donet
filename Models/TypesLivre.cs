
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TypesLivre
    {
        [Key]
        public int id_t { get; set; }
        public string? libelle_T { get; set; }
    }
}
