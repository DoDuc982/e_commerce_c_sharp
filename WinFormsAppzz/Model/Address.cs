using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppzz.NewFolder
{
    internal class Address
    {
        public long id { get; set; }

        public string? address { get; set; }

        public string? district { get; set; }

        public string? city { get; set; }

        public string? province { get; set; }

        public User? user { get; set; }
    }
}
