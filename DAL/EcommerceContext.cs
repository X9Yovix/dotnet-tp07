using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TP07.Models;

namespace TP07.DAL
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("EcommerceContext")
        { }

        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Marque> Marque { get; set; }
        public DbSet<Produit> Produit { get; set; }
    }
}