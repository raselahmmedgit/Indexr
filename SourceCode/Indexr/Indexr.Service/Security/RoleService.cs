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
using System.Linq;
using Indexr.Data;
using Indexr.Domain;

namespace Indexr.Service
{
    public class RoleService : IRoleService
    {
        #region Global Variable Declaration

        private readonly IRoleRepository _iRoleRepository;
        private readonly IUnitOfWork _iUnitOfWork;

        #endregion

        #region Constructor

        public RoleService(IRoleRepository iRoleRepository, IUnitOfWork iUnitOfWork)
        {
            this._iRoleRepository = iRoleRepository;
            this._iUnitOfWork = iUnitOfWork;
        }

        #endregion

        #region Get Method

        public IQueryable<Role> GetAll()
        {
            var roles = _iRoleRepository.GetAll();
            return roles as IQueryable<Role>;
        }

        //public IQueryable<Role> GetRoles()
        //{
        //    var roles = _iRoleRepository.GetAll();
        //    return roles as IQueryable<Role>;
        //}

        public Role GetRole(string roleName)
        {
            var role = _iRoleRepository.GetById(roleName);
            return role;
        }

        public IQueryable<User> GetUsersInRole(string roleName)
        {
            var users = new List<User>();
            var role = _iRoleRepository.GetById(roleName);

            if (role != null)
            {
                users = _iRoleRepository.GetById(roleName).Users.ToList();
            }

            return users.AsQueryable();
        }

        #endregion

        #region Create Method

        public int Create(Role role)
        {
            _iRoleRepository.Insert(role);
            return Save();
        }

        #endregion

        #region Update Method

        public int Update(Role role)
        {
            _iRoleRepository.Update(role);
            return Save();
        }

        #endregion

        #region Delete Method

        public int Delete(Role role)
        {
            var deleteRole = GetRole(role.RoleName);
            _iRoleRepository.Delete(deleteRole);
            return Save();
        }

        #endregion

        #region Save By Commit

        public int Save()
        {
            return _iUnitOfWork.Commit();
        }

        #endregion

    }
}
