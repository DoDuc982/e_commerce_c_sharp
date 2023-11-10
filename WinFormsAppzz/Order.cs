using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppzz
{
    internal class Order
    {

        public long id { get; set; }
        public long subTotal { get; set; } = 0;
        public long shippingPrice { get; set; } = 0;
        public long total { get; set; } = 0;
        public string discount { get; set; }
        public long grandTotal { get; set; } = 0;

        [Required(ErrorMessage = "Firstname is required")]
        public string? firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string? lastname { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(10, ErrorMessage = "Phone number must have exactly 10 digits", MinimumLength = 10)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Phone number must contain only digits")]
        public string? mobile { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string? address { get; set; }

        [Required(ErrorMessage = "District is required")]
        public string? district { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string? city { get; set; }

        [Required(ErrorMessage = "Province is required")]
        public string? province { get; set; }

        public string content { get; set; }
        public DateTime? createdOn { get; set; }
        public DateTime? updatedOn { get; set; }

        public User? user { get; set; }
        public List<OrderItem> orderItems { get; set; }
    }
}
