using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mysqlAppWeb.Models
{
    public class Course
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
        private String path;
        public virtual String Path
        {
            get { return path; }
            set { path = value; }
        }
       
    }
}