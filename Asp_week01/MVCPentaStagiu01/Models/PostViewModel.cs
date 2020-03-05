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
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        [Required]
        public string Message { get; set; }
        public PostType PostType { get; set; }
        public bool IsSticky { get; set; }

        private static int defaultPriority = 5;
        private int? priorityField = defaultPriority;
        [Range (0,6)]        
        [Display(Name ="Priority (1 to 5) : ")]
        public int? Priority
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