using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Service
{
    public interface IRoleService : IGeneric<Role>
    {
        //IQueryable<Role> GetRoles();
        Role GetRole(string roleName);
        
        IQueryable<User> GetUsersInRole(string roleName);
    }
}
