﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class ShoppingCart {
        public int id { get; set; }

        public int userId { get; set; }
        public User user { get; set; }
        
        public List<GameShoppingCartRel> gameShoppingCartRels { get; set; }
    }
}