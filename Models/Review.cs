﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class Review {
        public int id { get; set; }

        public string text { get; set; }

        [ScoreValidation]
        public int score { get; set; }

        public int gameId { get; set; }
        public Game game { get; set; }
    }
}