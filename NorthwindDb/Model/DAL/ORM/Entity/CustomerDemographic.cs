using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class CustomerDemographic:BaseEntity
    {
        public int CustomerTypeID { get; set; }
        public int CustomerDescription { get; set; }

        public virtual List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
