using System;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models {
    public class PasswordValidationAttribute : ValidationAttribute {
        public override bool IsValid(object value) {
            return Convert.ToString(value).Length > 6;
        }
    }
}