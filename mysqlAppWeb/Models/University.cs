using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mysqlAppWeb.Models
{
    public class University
    {
        private String id;
        public virtual String Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        private String adress;
        public virtual String Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private string email;
        public virtual string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string numTel;
        public virtual string NumTel
        {
            get { return numTel; }
            set { numTel = value; }
        }
        private String numFax;
        public virtual String NumFax
        {
            get { return numFax; }
            set { numFax = value; }
        }
        private String webSite;
        public virtual String WebSite
        {
            get { return webSite; }
            set { webSite = value; }
        }
        private int rib;
        public virtual int Rib
        {
            get { return rib; }
            set { rib = value; }
        }
       /* private IList<person> users;
        public IList<person> Users
        {
            get { return users; }
            set { users = value; }
        }*/

    }
}