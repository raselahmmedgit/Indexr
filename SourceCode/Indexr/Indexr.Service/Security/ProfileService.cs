using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Data;
using Indexr.Domain;

namespace Indexr.Service
{
    public class ProfileService : IProfileService
    {
        #region Global Variable Declaration

        private readonly IProfileRepository _iProfileRepository;
        private readonly IUnitOfWork _iUnitOfWork;

        #endregion

        #region Constructor

        public ProfileService(IProfileRepository iProfileRepository, IUnitOfWork iUnitOfWork)
        {
            this._iProfileRepository = iProfileRepository;
            this._iUnitOfWork = iUnitOfWork;
        }

        #endregion

        #region Get Method

        public IQueryable<Profile> GetAll()
        {
            var profiles = _iProfileRepository.GetAll();
            return profiles as IQueryable<Profile>;
        }

        //public IQueryable<Profile> GetProfiles()
        //{
        //    var profiles = _iProfileRepository.GetAll();
        //    return profiles as IQueryable<Profile>;
        //}

        public Profile GetProfile(int id)
        {
            var profile = _iProfileRepository.GetById(id);
            return profile;
        }

        #endregion

        #region Create Method

        public void Create(Profile profile)
        {
            _iProfileRepository.Insert(profile);
            Save();
        }

        #endregion

        #region Update Method

        public void Update(Profile profile)
        {
            _iProfileRepository.Update(profile);
            Save();
        }

        #endregion

        #region Delete Method

        public void Delete(Profile profile)
        {
            var deleteProfile = GetProfile(profile.Id);
            _iProfileRepository.Delete(deleteProfile);
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
