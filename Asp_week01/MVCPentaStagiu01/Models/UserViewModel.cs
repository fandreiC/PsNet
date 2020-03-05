using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPentaStagiu01.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name: ",
         Prompt = "Enter Name", Description = "UserName")]
        public string  FirstName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }

       
    }
}