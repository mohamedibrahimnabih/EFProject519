using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProject.Models
{
    class Category
    {
        //[Key]
        public int Id { get; set; }
        //[Column(TypeName = "varchar(50)")]
        //[MaxLength(50)]
        //[Unicode(false)]
        public string? Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
