using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Data
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory iDatabaseFactory)
            : base(iDatabaseFactory)
        {

        }

        public void AssignRole(string userName, List<string> roleNames)
        {
            User user = this.GetById(userName);
            if (user != null)
            {
                user.Roles.Clear();
                foreach (string roleName in roleNames)
                {
                    var role = this.DataContext.Roles.Find(roleName);
                    user.Roles.Add(role);
                }

                this.DataContext.Users.Attach(user);
                this.DataContext.Entry(user).State = EntityState.Modified;
            }
        }

    }

    public interface IUserRepository : IRepositoryBase<User>
    {
        void AssignRole(string userName, List<string> roleName);
    }
}
