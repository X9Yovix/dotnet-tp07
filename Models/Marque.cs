using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP07.Models
{
    public class Marque
    {
        [Key]
        public int IdMar { get; set; }
        public string Name { get; set; }
    }
}