using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCPentaStagiu01.Models
{

    public enum PostType
    {
        Text, Photo
    }

    public class PostViewModel
    {

        [Required]
        public int Id { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public string Message { get; set; }
        public PostType PostType { get; set; }
        public bool IsSticky { get; set; }

        private int priorityField;        
        public int Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                if (value > 0 && value < 6)
                    this.priorityField = value;
            }
        }
    }
}