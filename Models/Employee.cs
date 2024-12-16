using System.ComponentModel.DataAnnotations;

namespace SampleCRUDAPPASPNETMVC.Models
{
    public class Employee
    {
        [Key] // Specifies that this property is the primary key
        public int Portalid { get; set; }

        public string Empname { get; set; } // varChar in SQL corresponds to string in C#

        public string Designation { get; set; }

        public string Grade { get; set; }

        public int DepId { get; set; } // Assuming DepId is an integer

        public string Deptname { get; set; }
    }
}
