﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Models {
    public class Publisher {
        public int id { get; set; }

        [Required]
        [Remote("validatePublisherName", "Publisher", HttpMethod = "POST", ErrorMessage = "Name is exist.")]
        public string name { get; set; }

        public List<Game> games { get; set; }
    }
}