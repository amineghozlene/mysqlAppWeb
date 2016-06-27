using mysqlAppWeb.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mysqlAppWeb.Controllers
{
    public class LoginController : Controller
    {
        String username = "lordpein";
        String pass = "lufyland";
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Administrator p)
        {
            try
            {
                using (ISession session = NhibernateSession.OpenSession())
                {
                    var personne = session.Get<person>(p.Iduser);
                    if (!personne.Password.Equals(p.Password)) { throw new NullReferenceException(); }

                    return RedirectToAction("Index","Personne");
                }
            }catch(Exception e)
            {
                return View(p);
            }
            
        }

        
    }
}