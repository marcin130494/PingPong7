using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PingPong7.Data;
using PingPong7.Models;

namespace PingPong7.Controllers
{
 
    public class ZespolsController : Controller
    {
        public PingPong7Context db = new PingPong7Context();

        // GET: Zespols
        public ActionResult Index()
        {
            return View(db.Zespols.ToList());
        }

        // GET: Zespols/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zespol zespol = db.Zespols.Find(id);
            if (zespol == null)
            {
                return HttpNotFound();
            }
            return View(zespol);
        }

        // GET: Zespols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zespols/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeamName,Klub,Ulica,Telefon,Email")] Zespol zespol)
        {
            if (ModelState.IsValid)
            {
                db.Zespols.Add(zespol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zespol);
        }

        // GET: Zespols/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zespol zespol = db.Zespols.Find(id);
            if (zespol == null)
            {
                return HttpNotFound();
            }
            return View(zespol);
        }

        // POST: Zespols/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamName,Klub,Ulica,Telefon,Email")] Zespol zespol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zespol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zespol);
        }

        // GET: Zespols/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zespol zespol = db.Zespols.Find(id);
            if (zespol == null)
            {
                return HttpNotFound();
            }
            return View(zespol);
        }

        // POST: Zespols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Zespol zespol = db.Zespols.Find(id);
            db.Zespols.Remove(zespol);
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
