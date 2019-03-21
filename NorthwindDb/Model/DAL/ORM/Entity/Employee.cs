using NorthwindDb.Money.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDb.Money.DAL.ORM.Entity
{
    public class Employee:BaseEntity
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address{ get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public short HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public Role Role { get; set; }

        public virtual List<Employee> Employees { get; set; }
        public virtual List<EmployeeTerritory> EmployeeTerritories { get; set; }
        public virtual List<Order> Orders { get; set; }









    }
}
