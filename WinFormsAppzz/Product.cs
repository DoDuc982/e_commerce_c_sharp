using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppzz
{
    internal class Product
    {
        public long id { get; set; }

        public string? name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, long.MaxValue, ErrorMessage = "Price must be greater than or equal to 0")]
        public long? price { get; set; }

        public long? discountPrice { get; set; }

        public string? imageUrl { get; set; }

        public int? quantity { get; set; }

        public int? soldQuantity { get; set; }

        public string? content { get; set; }

        public DateTime? createdOn { get; set; }
        public DateTime? updatedOn { get; set; }

        public Category? category { get; set; }
    }
}
