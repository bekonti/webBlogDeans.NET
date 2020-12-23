using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DeansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Deans
        public ActionResult Index()
        {
            return View(db.Deans.ToList());
        }

        // GET: Deans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deans deans = db.Deans.Find(id);
            if (deans == null)
            {
                return HttpNotFound();
            }
            return View(deans);
        }

        // GET: Deans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deans/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Deans deans)
        {
            if (ModelState.IsValid)
            {
                db.Deans.Add(deans);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deans);
        }

        // GET: Deans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deans deans = db.Deans.Find(id);
            if (deans == null)
            {
                return HttpNotFound();
            }
            return View(deans);
        }

        // POST: Deans/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Deans deans)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deans).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deans);
        }

        // GET: Deans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deans deans = db.Deans.Find(id);
            if (deans == null)
            {
                return HttpNotFound();
            }
            return View(deans);
        }

        // POST: Deans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Deans deans = db.Deans.Find(id);
            db.Deans.Remove(deans);
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
