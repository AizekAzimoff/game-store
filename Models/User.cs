﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class User {
        public int id { get; set; }

        public string name { get; set; }

        public string mail { get; set; }

        public string password { get; set; }

        public int shoppingCartId { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}