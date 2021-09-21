using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTB1.Models
{
    [Table("Employees")]
    public class Employee
    {
        internal object e;

        [Key]
        public string EmployeeNow { get; set; }
    }
}