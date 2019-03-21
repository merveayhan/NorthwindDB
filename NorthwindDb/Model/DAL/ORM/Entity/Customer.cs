using NorthwindDb.Money.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class Customer:BaseEntity
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public short Phone { get; set; }
        public short Fax { get; set; }
        public Role Role { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }





    }
}
