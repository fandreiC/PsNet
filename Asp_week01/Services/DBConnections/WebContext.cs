using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DBConnections
{
    class WebContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public WebContext() : base("WebContext")
        { }

        private class UniDBInitializer<T> : DropCreateDatabaseAlways<WebContext>
        {
            protected override void Seed(WebContext context)
            {
                IList<UserModel> users = new List<UserModel>();

                users.Add(new UserModel()
                {
                    FirstName = "Alex",
                    Age = 55,
                    Email = "Alex@ASP.ro"
                });

                users.Add(new UserModel()
                {
                    FirstName = "Bogdan",
                    Age = 21,
                    Email = "Bogdan@ASP.com"
                });

                users.Add(new UserModel()
                {
                    FirstName = "Maria",
                    Age = 37,
                    Email = "Maria@ASP.org"
                });

                foreach (UserModel user in users)
                {
                    context.Users.Add(user);
                }

                base.Seed(context);
            }
        }

    }
}
