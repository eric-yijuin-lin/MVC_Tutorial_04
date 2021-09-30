using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Tutorial_04.Models
{
    public partial class CreateUserViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string UserAccout { get; set; }
        [StringLength(20, MinimumLength = 4)]
        public string UserPassword { get; set; }
        [StringLength(20, MinimumLength = 4)]
        public string ComfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string UserMail { get; set; }
        public string ErrorMessage { get; set; }
    }
}
