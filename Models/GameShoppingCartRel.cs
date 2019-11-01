﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class GameShoppingCartRel {
        public int gameId { get; set; }
        public Game game { get; set; }

        public int shoppingCartId { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}