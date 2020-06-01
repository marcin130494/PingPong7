using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PingPong7.Models;
using PingPong7.Data;

namespace PingPong7.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Index()
        {
            using (PingPong7Context db = new PingPong7Context())
            {
                return View(db.Accounts.ToList());
            }

        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

     

        [HttpPost]
        public ActionResult Login(Account acc)
        {
            using(PingPong7Context db = new PingPong7Context())
            {
                var usr = db.Accounts.Single(u => u.Name == acc.Name && u.Password == acc.Password);
                if (usr != null)
                {
                    Session["LoginId"] = usr.LoginId.ToString();
                    Session["Name"] = usr.Name.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Name or Password is wrong");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["LoginId"] != null){
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Tabelas");
        }
    }
}