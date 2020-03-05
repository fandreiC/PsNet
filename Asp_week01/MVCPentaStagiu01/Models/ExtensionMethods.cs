using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPentaStagiu01.Models
{
    public static class ExtensionMethods
    {
        public static UserViewModel ToViewModel(this UserModel userModel)
        {

            UserViewModel userVM = new UserViewModel()
            {
                Id=userModel.Id,
                FirstName= userModel.FirstName,
                Age=userModel.Age,
                Email=userModel.Email
            };
            return userVM;
        }

        public static UserModel ToModel(this UserViewModel userVM)
        {

            UserModel userModel = new UserModel()
            {
             //   Id = userVM.Id,
                FirstName = userVM.FirstName,
                Age = userVM.Age,
                Email = userVM.Email
            };
            return userModel;
        }

    }
}