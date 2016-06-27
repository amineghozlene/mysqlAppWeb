using mysqlAppWeb.Controllers;
using mysqlAppWeb.Models;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using System;
using System.Linq;
using System.Web.Mvc;

namespace mysqlAppWeb.Controllers
{
    public class PersonneController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        //Create : Personne
        [HttpPost]
        public ActionResult Create(Administrator personne)
        {
            try
            {
                using (ISession session = NhibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(personne);
                        transaction.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }
        
        // Read: Personne
        public ActionResult Index()
        {
            using (ISession session = NhibernateSession.OpenSession())
            {
                var personnes = session.Query<person>().ToList();
                return View(personnes);
            }
           
            
            // return "hello wolrd !";
        }

        
        

        //Update : Personne
        public ActionResult Edit(String id)
        {
            using (ISession session = NhibernateSession.OpenSession())
            {
                var personne = session.Get<person>(id);
                return View(personne);
            }

        }


        [HttpPost]
        public ActionResult Edit(String id, person personne)
        {
            try
            {
                using (ISession session = NhibernateSession.OpenSession())
                {
                    var personnetoUpdate = session.Get<person>(id);

                    personnetoUpdate.Iduser = personne.Iduser;
                    personnetoUpdate.Password = personne.Password;
                    

                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(personnetoUpdate);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //Delete : Personne
        public ActionResult Delete(String id)
        {
            using (ISession session = NhibernateSession.OpenSession())
            {
                var personne = session.Get<person>(id);
                return View(personne);
            }
        }


        [HttpPost]
        public ActionResult Delete(String id, person personne)
        {
            try
            {
                using (ISession session = NhibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(personne);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }
    }
}