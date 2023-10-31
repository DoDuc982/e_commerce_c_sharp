using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppzz.NewFolder
{
    internal class Category
    {
        public long id { get; set; }

        public string? name { get; set; }

        public string? content { get; set; }

        public DateTime? createdOn { get; set; }
        
        public DateTime updatedOn { get; set; }

        public List<Product> products { get; set; }
    }
}
