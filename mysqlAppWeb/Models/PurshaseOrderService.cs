using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mysqlAppWeb.Models
{
    public class PurshaseOrderService
    {
        private int id;
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime purchaseDate;
        public virtual DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }
        private float price;
        public virtual float Price
        {
            get { return price; }
            set { price = value; }
        }
        private DateTime expirationDate;
        public virtual DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
    }
}