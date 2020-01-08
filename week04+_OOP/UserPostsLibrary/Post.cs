using System;
using System.Collections.Generic;
using System.Text;

namespace UserPostsLibrary
{
    public class Post : IComparable<Post>
    {
        private static int postID = 0;
        private static int adjustCreationTime = 5;
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }

        public Post(User author, string message)
        {
            this.AuthorId = author.UserId;
            this.Author = author;
            this.Message = message;
            this.CreationDate = DateTime.Now.AddDays(-adjustCreationTime);
            this.PostId = ++postID;
            adjustCreationTime += 5;
        }
        public int CompareTo(Post otherPost)
        {
            if (this.CreationDate == otherPost.CreationDate)
            {
                return this.CreationDate.CompareTo(otherPost.CreationDate);               // desc
                                                                                          // return otherPost.CreationDate.CompareTo(this.CreationDate);           // asc
            }
            return otherPost.CreationDate.CompareTo(this.CreationDate);                 // desc
            //return this.CreationDate.CompareTo(otherPost.CreationDate);               // asc
        }

        public void PrintPost()
        {
            Console.Write($" Posted by: {this.Author.FullName}");
            Console.WriteLine($" {this.PostId}, {this.Message}, {this.CreationDate.ToShortDateString()}");
        }

    }
}
