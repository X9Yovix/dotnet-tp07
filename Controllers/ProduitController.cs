using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TP07.DAL;
using TP07.Models;

namespace TP07.Controllers
{
    public class ProduitController : Controller
    {
        private EcommerceContext _context = new EcommerceContext();
        // GET: Produit
        public ActionResult Index()
        {
            var produits = _context.Produit.Include(p => p.Categorie).Include(p => p.Marque);

            return View(produits.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategorieId = new SelectList(_context.Categorie, "IdCat", "Name");
            ViewBag.MarqueId = new SelectList(_context.Marque, "IdMar", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, CategorieId, MarqueId, Name, Price, Qte")] Produit produit)
        {
            if (ModelState.IsValid)
            {
                _context.Produit.Add(produit);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategorieId = new SelectList(_context.Categorie, "IdCat", "Name", produit.CategorieId);
            ViewBag.MarqueId = new SelectList(_context.Marque, "IdMar", "Name", produit.MarqueId);
            return View(produit);
        }
    }
}