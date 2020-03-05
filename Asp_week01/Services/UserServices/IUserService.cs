using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserService
    {
        List<UserModel> GetAll();
        UserModel Get(int id);
        UserModel Insert(UserModel userModel);
        UserModel Edit(UserModel userModel);
        List<UserModel> Delete(int id);
        //List<UserModel> GenerateList();
    }
}
