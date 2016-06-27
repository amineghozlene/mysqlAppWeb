using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mysqlAppWeb.Models
{
    public class Service
    {
        private int id;
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;
        public virtual string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string description;
        public virtual string Description
        {
            get { return description; }
            set { description = value; }
        }
        private float price;
        public virtual float Price
        {
            get { return price; }
            set { price = value; }
        }
        private String pathLicence;
        public virtual String PathLicence
        {
            get { return pathLicence; }
            set { pathLicence = value; }
        }
    }
}