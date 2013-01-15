/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Designed and Implemented By:
Rasel Ahmmed
Software Engineer, I Like .NET
Twitter: http://twitter.com/raselbappi | Blog: http://springsolution.net | About Me: http://springsolution.net/about-me/
   
*******************************************************/

using System.Collections.Generic;
using System.Data;
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
