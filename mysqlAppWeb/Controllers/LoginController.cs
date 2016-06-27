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
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String id)
        {
            try
            {
                using (ISession session = NhibernateSession.OpenSession())
                {
                    var personne = session.Get<person>(id);
                    return RedirectToAction("Personne/Index");
                }
            }catch(Exception e)
            {
                return View();
            }
        }
    }
}