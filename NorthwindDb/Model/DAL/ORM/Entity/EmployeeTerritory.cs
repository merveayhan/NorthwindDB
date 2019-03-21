using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class EmployeeTerritory:BaseEntity
    {
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public int TerritoryID { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
