﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppzz
{
    internal class CartItem
    {

        public long Id { get; set; }

        public int quantity { get; set; }

        public int userId { get; set; }
        public int productId { get; set; }
    }
}
