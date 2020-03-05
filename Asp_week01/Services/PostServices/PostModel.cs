using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PostServices
{
    public enum PostType
    {
        Text, Photo
    }
    class PostModel
    {
        private static int idIncrementer = 0;
        private int idField;
        public int Id { get { return idField; } }
        public int UserId { get; set; }
        public DateTime TimeOfPosting { get; set; }        
        public string Message { get; set; }
        public PostType PostType { get; set; }
        public bool IsSticky { get; set; }

        private static int defaultPriority = 5;
        private int priorityField = defaultPriority;
        public int Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {                
                this.priorityField = value;
            }

        }

        public PostModel()
        {
            this.idField = ++idIncrementer;
            this.priorityField = defaultPriority;
        }
    }
}
