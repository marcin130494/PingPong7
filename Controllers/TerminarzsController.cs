using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PingPong7.Data;
using PingPong7.Models;

namespace PingPong7.Controllers
{
    public class TerminarzsController : Controller
    {
        public PingPong7Context db = new PingPong7Context();

        // GET: Terminarzs
     //   public ActionResult Index()
      //  {
      //      var terminarzs = db.Terminarzs.Include(t => t.Zespol);
      //      return View(terminarzs.ToList());
      //  }


         public ActionResult Index(int? page, int? pageSize)  
     {  
         
         int pageIndex = 1;  
         pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;  
  
           
         //Ddefault size is 5 otherwise take pageSize value  
         int defaSize = (pageSize ?? 6);  
  
         ViewBag.psize = defaSize;  
  
         //Dropdownlist code for PageSize selection  
         //In View Attach this  
         ViewBag.PageSize = new List<SelectListItem>()  
         {  
             new SelectListItem() { Value="6", Text= "6" },  
         };  
  
         //Create a instance of our DataContext  
         PingPong7Context _dbContext = new PingPong7Context();  
  
  
         IPagedList<Terminarz> involst = null;  
  
         //Alloting nos. of records as per pagesize and page index.  
         involst = _dbContext.Terminarzs.OrderBy(x => x.Id_terminarz).ToPagedList(pageIndex, defaSize);  
  
         return View(involst);  
     }  



        // GET: Terminarzs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminarz terminarz = db.Terminarzs.Find(id);
            if (terminarz == null)
            {
                return HttpNotFound();
            }
            return View(terminarz);
        }

        // GET: Terminarzs/Create
        public ActionResult Create()
        {
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub");
            ViewBag.TeamName1 = new SelectList(db.Zespols, "TeamName", "Klub");
            return View();
        }

        // POST: Terminarzs/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_terminarz,TeamName,Wynik,TeamName1")] Terminarz terminarz)
        {
            if (ModelState.IsValid)
            {
                db.Terminarzs.Add(terminarz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", terminarz.TeamName);
            ViewBag.TeamName1 = new SelectList(db.Zespols, "TeamName", "Klub", terminarz.TeamName);
            return View(terminarz);
        }

        // GET: Terminarzs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminarz terminarz = db.Terminarzs.Find(id);
            if (terminarz == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", terminarz.TeamName);
            ViewBag.TeamName1 = new SelectList(db.Zespols, "TeamName", "Klub", terminarz.TeamName1);
            return View(terminarz);
        }

        // POST: Terminarzs/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_terminarz,TeamName,Wynik,TeamName1")] Terminarz terminarz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(terminarz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeamName = new SelectList(db.Zespols, "TeamName", "Klub", terminarz.TeamName);
            ViewBag.TeamName1 = new SelectList(db.Zespols, "TeamName", "Klub", terminarz.TeamName1);
            return View(terminarz);
        }

        // GET: Terminarzs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terminarz terminarz = db.Terminarzs.Find(id);
            if (terminarz == null)
            {
                return HttpNotFound();
            }
            return View(terminarz);
        }

        // POST: Terminarzs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Terminarz terminarz = db.Terminarzs.Find(id);
            db.Terminarzs.Remove(terminarz);
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
