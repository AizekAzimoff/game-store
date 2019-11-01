﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class Genre {
        public int id { get; set; }

        public string name { get; set; }

        public List<GameGenreRel> gameGenreRels { get; set; }
    }
}