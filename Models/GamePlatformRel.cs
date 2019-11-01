﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class GamePlatformRel {
        public int gameId { get; set; }
        public Game game { get; set; }

        public int platformId { get; set; }
        public Platform platform { get; set; }
    }
}