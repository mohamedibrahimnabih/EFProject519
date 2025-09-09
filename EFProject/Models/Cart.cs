using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    [PrimaryKey(nameof(ProductId), nameof(UserId))]
    class Cart
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
