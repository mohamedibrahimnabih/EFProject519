using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolveChallenge.Models
{
    class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Unicode(false)]
        [MaxLength(100)]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string MainImg { get; set; }
    }
}
