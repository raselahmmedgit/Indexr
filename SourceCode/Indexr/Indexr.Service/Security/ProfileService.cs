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

using System.Linq;
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

        public int Create(Profile profile)
        {
            _iProfileRepository.Insert(profile);
            return Save();
        }

        #endregion

        #region Update Method

        public int Update(Profile profile)
        {
            _iProfileRepository.Update(profile);
            return Save();
        }

        #endregion

        #region Delete Method

        public int Delete(Profile profile)
        {
            var deleteProfile = GetProfile(profile.Id);
            _iProfileRepository.Delete(deleteProfile);
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
