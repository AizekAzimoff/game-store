using System;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class ScoreValidationAttribute : ValidationAttribute {
        public override bool IsValid(object value) {
            return Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <=100;
        }
    }
}