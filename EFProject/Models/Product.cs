using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string MainImg { get; set; }

        public Category Category { get; set; }
        //public List<User> Users { get; set; }
    }
}
