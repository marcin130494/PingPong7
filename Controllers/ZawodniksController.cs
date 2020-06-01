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
    public class ZawodniksController : Controller
    {
        public PingPong7Context db = new PingPong7Context();

        // GET: Zawodniks
        public ActionResult Index()
        {
            var zawodniks = db.Zawodniks.Include(z => z.Zespol);
            return View(zawodniks.ToList());
        }

        public ActionResult ListaRankingowa()
        {

            var lista = from s in db.Zawodniks select s;

            lista = lista.OrderByDescending(s => s.Wygrane);

            return View(lista.ToList());
        }

        // GET: Zawodniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zawodnik zawodnik = db.Zawodniks.Find(id);
            if (zawodnik == null)
            {
                return HttpNotFound();
            }
            return View(zawodnik);
        }

        // GET: Zawodniks/Create
        public ActionResult Create()
        {
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub");
            return View();
        }

        // POST: Zawodniks/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerkId,Imie,Nazwisko,Wygrane,Przegrane,TeamName")] Zawodnik zawodnik)
        {
            if (ModelState.IsValid)
            {
                db.Zawodniks.Add(zawodnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", zawodnik.TeamName);
            return View(zawodnik);
        }

        // GET: Zawodniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zawodnik zawodnik = db.Zawodniks.Find(id);
            if (zawodnik == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", zawodnik.TeamName);
            return View(zawodnik);
        }

        // POST: Zawodniks/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerkId,Imie,Nazwisko,Wygrane,Przegrane,TeamName")] Zawodnik zawodnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zawodnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", zawodnik.TeamName);
            return View(zawodnik);
        }

        // GET: Zawodniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zawodnik zawodnik = db.Zawodniks.Find(id);
            if (zawodnik == null)
            {
                return HttpNotFound();
            }
            return View(zawodnik);
        }

        // POST: Zawodniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zawodnik zawodnik = db.Zawodniks.Find(id);
            db.Zawodniks.Remove(zawodnik);
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
