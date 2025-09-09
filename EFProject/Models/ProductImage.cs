using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    //[PrimaryKey(nameof(Img), nameof(ProductId))]
    //[Table("ProductImage", Schema = "sales")]
    class ProductImage
    {
        public string Img { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Size { get; set; }
    }

    class ProductImagePrimary
    {
        public string Img { get; set; }
        public int ProductId { get; set; }
    }
}
