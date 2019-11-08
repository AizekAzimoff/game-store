﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Models {
    public class Platform {
        public int id { get; set; }

        [Required]
        [Remote("validatePlatformName", "Platform", HttpMethod = "POST", ErrorMessage = "Name is exist.")]
        public string name { get; set; }

        public List<GamePlatformRel> gamePlatformRels { get; set; }
    }
}