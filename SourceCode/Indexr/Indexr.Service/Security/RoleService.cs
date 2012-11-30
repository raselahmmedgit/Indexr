using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void Create(Role role)
        {
            _iRoleRepository.Insert(role);
            Save();
        }

        #endregion

        #region Update Method

        public void Update(Role role)
        {
            _iRoleRepository.Update(role);
            Save();
        }

        #endregion

        #region Delete Method

        public void Delete(Role role)
        {
            var deleteRole = GetRole(role.RoleName);
            _iRoleRepository.Delete(deleteRole);
            Save();
        }

        #endregion

        #region Save By Commit

        public void Save()
        {
            _iUnitOfWork.Commit();
        }

        #endregion

    }
}
