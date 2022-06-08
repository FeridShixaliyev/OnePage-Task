﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.ViewModels.Authorization
{
    public class RegisterVM
    {
        [Required,MaxLength(50)]
        public string FirstName { get; set; }
        [Required,MaxLength(50)]
        public string LastName { get; set; }
        [Required,MaxLength(30)]
        public string Username { get; set; }
        [Required,MaxLength(25)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
