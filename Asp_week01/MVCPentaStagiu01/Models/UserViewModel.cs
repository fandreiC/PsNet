using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPentaStagiu01.Models
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "Nume" )]
        public string  FirstName { get; set; }

        public int Age { get; set; }
    }
}