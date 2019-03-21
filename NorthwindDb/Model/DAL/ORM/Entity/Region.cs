using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class Region:BaseEntity
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }



        public virtual List<Territory> Territories { get; set; }
    }
}
