using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public string? address { get; set; }
        public string image { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual Department? Department { get; set; }
    }
}
