using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class Product:BaseEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }




    }
}
