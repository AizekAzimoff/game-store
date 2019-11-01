﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class Game {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string imageUrl { get; set; }

        public List<Genre> genres { get; set; }

        public double price { get; set; }

        public int developerId { get; set; }
        public Developer developer { get; set; } 

        public int publisherId { get; set; }
        public Publisher publisher { get; set; }

        public List<Review> reviews { get; set; }

        public List<GameGenreRel> gameGenreRels { get; set; }

        public List<GamePlatformRel> gamePlatformRels { get; set; }

        public List<GameShoppingCartRel> gameShoppingCartRels { get; set; }
    }
}