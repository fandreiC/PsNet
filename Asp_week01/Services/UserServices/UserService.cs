using Services.DBConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {

        public List<UserModel> GetAllUserModels()
        {
            using (var context = new WebContext())
            {
                return context.Users.Select(u => u.ToViewModel()).ToList();
            }
        }


        private static List<UserModel> _usersList = GenerateList();
        public UserService()
        {
           // _usersList = GenerateList();
        }        
        public UserModel Insert(UserModel userModel)
        {
          //  var usersList = GenerateList();
            _usersList.Add(userModel);

            return userModel;
        }
       
        public UserModel Edit(UserModel userModel)
        {
            if (userModel == null)
            {
                return null;
            }
              //var usersList = GenerateList();
            //var existingModel = usersList.Where(u => u.UserId == userModel.UserId).FirstOrDefault();
            //if (existingModel == null)           
            //    return null;
           
            var index = _usersList.FindIndex(u => u.Id == userModel.Id);
            _usersList[index].FirstName = userModel.FirstName;
            _usersList[index].Age = userModel.Age;
            _usersList[index].Email = userModel.Email;

            return userModel;
        }

        public List<UserModel> Delete(int id)
        {
            //var usersList = GenerateList();

            var existingModel = _usersList.Where(u => u.Id == id).FirstOrDefault();
            _usersList.Remove(existingModel);

            return _usersList;
        }

        public UserModel Get(int id)
        {
            //var usersList = GenerateList();
            UserModel existingModel = _usersList.Where(u => u.Id == id).FirstOrDefault();
            
            return existingModel;
        }

        public List<UserModel> GetAll()
        {
            return _usersList;
        }

        public static List<UserModel> GenerateList()
        {
            UserModel userViewModel1 = new UserModel
            {
                Age = 45,
                FirstName = "Tom",
                Email = "Tom@Cat.com"
            };
            UserModel userViewModel2 = new UserModel
            {
                Age = 72,
                FirstName = "Jim",
                Email = "Jim@Cat.com"
            };
            UserModel userViewModel3 = new UserModel
            {
                Age = 17,
                FirstName = "Hulk",
                Email = "Hulk@Cat.com"
            };

            List<UserModel> users = new List<UserModel>
            { userViewModel1,userViewModel2,userViewModel3};

            return users;
        }
    }
}
