using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP07.Models
{
    public class Categorie
    {
        [Key]
        public int IdCat { get; set; }
        public string Name { get; set; }
    }
}