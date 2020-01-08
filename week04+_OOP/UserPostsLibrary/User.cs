using System;
using System.Collections.Generic;

namespace UserPostsLibrary
{
    public class User
    {
        private static int userId = 100;
        public int UserId { get; set; }
        public List<int> PostsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public User()
        {
            this.FirstName = "defFName";
            this.LastName = "defLName";
            this.FullName = FirstName + " " + LastName;
            this.Birthday = DateTime.Now.AddYears(-20);
            this.UserId = ++userId;
            this.Email = "asd@PentaStagiu.ro";
        }
        public User(string name) : this(name, " - ", DateTime.Now.AddYears(-20)) { }
        public User(string FName, string LName, DateTime birthDay)
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.FullName = FirstName + " " + LastName;
            this.Birthday = birthDay;
            this.UserId = ++userId;
            this.Email = "asd@PentaStagiu.ro";
        }
        public void PrintUser()
        {
            Console.WriteLine($" {this.UserId},  {this.FullName} : ");
        }

    }
}