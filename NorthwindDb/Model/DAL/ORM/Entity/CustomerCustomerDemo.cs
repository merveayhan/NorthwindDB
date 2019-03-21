using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class CustomerCustomerDemo:BaseEntity
    {

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public int CustomerTypeID { get; set; }
        public virtual CustomerDemographic CustomerDemographic { get; set; }


    }
}
