using NorthwindDb.Money.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class Shipper:BaseEntity
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
