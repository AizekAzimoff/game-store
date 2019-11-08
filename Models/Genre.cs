﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Models {
    public class Genre : IValidatableObject {
        public int id { get; set; }

        [Remote("validateGenreName", "Genre", HttpMethod = "POST", ErrorMessage = "Name is exist.")]
        public string name { get; set; }

        public List<GameGenreRel> gameGenreRels { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.name))
            {
                errors.Add(new ValidationResult("Please fill name."));
            }
            else if (new Regex("[!@#$%^&*(),.?\":{}|<>]").Matches(this.name).Count > 0)
            {
                errors.Add(new ValidationResult("Invalid symbols."));
            }
            return errors;
        }
    }
}