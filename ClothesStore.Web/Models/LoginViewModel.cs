using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClothesStore.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter your Login please")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter your Password please")]
        public string Password { get; set; }
    }
}