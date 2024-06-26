﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TP07.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qte { get; set; }

        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public Categorie Categorie { get; set; }

        public int MarqueId { get; set; }
        [ForeignKey("MarqueId")]
        public Marque Marque { get; set; }
    }
}