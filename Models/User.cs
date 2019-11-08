﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Models {
    public class User {
        public int id { get; set; }

        public string name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage="Invalid Email addresss")]
        [Remote("validateUserMail", "User", HttpMethod = "POST", ErrorMessage = "Mail is exist.")]
        public string mail { get; set; }

        [Required]
        [PasswordValidation]
        public string password { get; set; }

        public int shoppingCartId { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}