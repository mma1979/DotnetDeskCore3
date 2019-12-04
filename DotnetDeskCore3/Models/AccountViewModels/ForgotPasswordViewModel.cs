﻿using System.ComponentModel.DataAnnotations;

namespace DotnetDeskCore3.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
