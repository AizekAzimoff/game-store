﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class Developer {
        public int id { get; set; }

        public string name { get; set; }

        public List<Game> games { get; set; }
    }
}