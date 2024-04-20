using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TP07.DAL;
using TP07.Models;

namespace TP07.Controllers
{
    public class MarqueController : Controller
    {
        private EcommerceContext db = new EcommerceContext();

        // GET: Marque
        public ActionResult Index()
        {
            return View(db.Marque.ToList());
        }

        // GET: Marque/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marque marque = db.Marque.Find(id);
            if (marque == null)
            {
                return HttpNotFound();
            }
            return View(marque);
        }

        // GET: Marque/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marque/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMar,Name")] Marque marque)
        {
            if (ModelState.IsValid)
            {
                db.Marque.Add(marque);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marque);
        }

        // GET: Marque/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marque marque = db.Marque.Find(id);
            if (marque == null)
            {
                return HttpNotFound();
            }
            return View(marque);
        }

        // POST: Marque/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMar,Name")] Marque marque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marque);
        }

        // GET: Marque/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marque marque = db.Marque.Find(id);
            if (marque == null)
            {
                return HttpNotFound();
            }
            return View(marque);
        }

        // POST: Marque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marque marque = db.Marque.Find(id);
            db.Marque.Remove(marque);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
