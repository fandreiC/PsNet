using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPostsLibrary;

namespace UserPostsApp
{
    class CommonBoard
    {
        public Dictionary<User, List<Post>> MyBoard { get; set; }
        public List<User> MyUsers { get; set; }
        public List<Post> MyPosts { get; set; }
        public List<Account> MyAccounts { get; set; }

        public CommonBoard()
        {
            this.MyUsers = new List<User>();
            this.MyPosts = new List<Post>();
            this.MyBoard = new Dictionary<User, List<Post>>();
            this.MyAccounts = new List<Account>();
        }

        public void InsertPost(Post message)
        {
            this.MyPosts.Add(message);

            List<Post> Plist = new List<Post>();
            Plist.Add(message);

            if (MyBoard.ContainsKey(message.Author))
            {
                this.MyBoard[message.Author].Add(message);
            }
            else
            {
                this.MyBoard.Add(key: message.Author, value: Plist);
                this.MyUsers.Add(message.Author);
            }

        }

        public void DisplayAllPosts()
        {
            foreach (var user in MyBoard)
            {
                user.Key.PrintUser();
                foreach (var post in user.Value)
                {
                    post.PrintPost();
                }
            }
        }
        public void DisplayAllPostsChronologically()
        {
            MyPosts = MyPosts.OrderByDescending(o => o.CreationDate).ToList();
            foreach (var post in MyPosts)
            {
                post.PrintPost();
            }
        }
        public void DisplayPostUsingIComparable()
        {
            MyPosts.Sort();
            foreach (var post in MyPosts)
            {
                post.PrintPost();
            }
        }
        public User GetUserById(int id)
        {
            User user = MyUsers.FirstOrDefault(u => u.UserId == id);
            return user;
        }

        public void CreateAccount(User user)
        {
            int a = MyAccounts.FindIndex(f => f.UserName == user.FullName);
            if (a < 0)
            {
                MyAccounts.Add(new Account(user));
            }
        }
        public void PrintAccounts()
        {
            Console.WriteLine("Accounts: ");
            foreach (var account in MyAccounts)
            {
                Console.WriteLine($" {account.UserName} , {account.Email}");
            }
        }
        public void PostMessage(User user, string message)
        {
            CreateAccount(user);
            Post post = new Post(user, message);
            MyPosts.Add(post);
        }


    }

}
