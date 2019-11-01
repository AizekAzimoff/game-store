﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class GameGenreRel {
        public int gameId { get; set; }
        public Game game { get; set; }

        public int genreId { get; set; }
        public Genre genre { get; set; }
    }
}