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
    public class TabelasController : Controller
    {
        public PingPong7Context db = new PingPong7Context();

        // GET: Tabelas
        public ActionResult Index()
        {
            var tabela = from s in db.Tabelas select s;

            tabela = tabela.OrderByDescending(s => s.Punkty);
                    
            //tabela = db.Tabelas.Include(t => t.Zespol);
            return View(tabela.ToList());
        }

        // GET: Tabelas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tabela tabela = db.Tabelas.Find(id);
            if (tabela == null)
            {
                return HttpNotFound();
            }
            return View(tabela);
        }

        // GET: Tabelas/Create
        public ActionResult Create()
        {
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub");
            return View();
        }

        // POST: Tabelas/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TableId,Rozegrano,Wygrane,Zremisowane,Przegrane,Punkty,TeamName")] Tabela tabela)
        {
            if (ModelState.IsValid)
            {
                db.Tabelas.Add(tabela);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", tabela.TeamName);
            return View(tabela);
        }

        // GET: Tabelas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tabela tabela = db.Tabelas.Find(id);
            if (tabela == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", tabela.TeamName);
            return View(tabela);
        }

        // POST: Tabelas/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TableId,Rozegrano,Wygrane,Zremisowane,Przegrane,Punkty,TeamName")] Tabela tabela)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabela).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", tabela.TeamName);
            return View(tabela);
        }

        // GET: Tabelas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tabela tabela = db.Tabelas.Find(id);
            if (tabela == null)
            {
                return HttpNotFound();
            }
            return View(tabela);
        }

        // POST: Tabelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tabela tabela = db.Tabelas.Find(id);
            db.Tabelas.Remove(tabela);
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
