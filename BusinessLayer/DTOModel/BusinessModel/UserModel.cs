using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspDotNetCore.Services.DTOModel.BusinessModel
{
    public class UserModel
    {
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="You must specify password between 4 and 8 charector.")]
        public string Password { get; set; }
    }
}
