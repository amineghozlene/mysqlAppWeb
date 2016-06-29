using mysqlAppWeb.Models;
using NHibernate;
using System;
using System.Web.Mvc;
using System.Web.SessionState;

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
        public ActionResult Index(person p)
        {
            try
            {
                using (ISession session = NhibernateSession.OpenSession())
                {
                    
                    var personne = session.Get<person>(p.Iduser);
                    if (!personne.Password.Equals(p.Password)) { throw new NullReferenceException(); }
                     Session["user"] = personne.FirstName;
                     Session.Timeout = 10;
                   
                    return RedirectToAction("Index","Personne");
                }
            }catch(Exception e)
            {
                return View();
            }
            
        }

        
    }
}