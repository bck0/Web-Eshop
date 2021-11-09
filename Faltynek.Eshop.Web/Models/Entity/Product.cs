using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web.Models.Entity
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        [StringLength(255)]
        [Required]
        public string ImageSource { get; set; }
        [StringLength(50)]
        public string ImageAlt { get; set; }
        [Required]
        public double Price { get; set; }
        [StringLength(1024)]
        [Required]
        public string Info { get; set; }
    }
}
