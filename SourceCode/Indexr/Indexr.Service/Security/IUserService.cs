using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Service
{
    public interface IUserService : IGeneric<User>
    {
        //IQueryable<User> GetUsers();
        //IQueryable<User> GetLoggedInUsers();
        User GetUser(string userName);

        //void ChangeUserLogInStatus(User user, bool inout);

        void AddUserToRole(string userName, List<string> roleNames);

        bool ForgetPassword(User user);
        string HashResetParams(string userName);
    }
}
