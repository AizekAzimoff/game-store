﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class Platform {
        public int id { get; set; }

        public string name { get; set; }

        public List<GamePlatformRel> gamePlatformRels { get; set; }
    }
}