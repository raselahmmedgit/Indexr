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
using Indexr.DomainView;

namespace Indexr.Service
{
    public class ContactInfoService : IContactInfoService
    {
        #region Global Variable Declaration

        private readonly IContactInfoRepository _iContactInfoRepository;
        private readonly IUnitOfWork _iUnitOfWork;

        #endregion

        #region Constructor

        public ContactInfoService(IContactInfoRepository iContactInfoRepository, IUnitOfWork iUnitOfWork)
        {
            this._iContactInfoRepository = iContactInfoRepository;
            this._iUnitOfWork = iUnitOfWork;
        }

        #endregion

        #region Get Method

        //public IQueryable<ContactInfoViewModel> GetContactInfos()
        //{
        //    var contactInfos = _iContactInfoRepository.GetAll();
        //    var contactInfoViewModel = contactInfos.Select(EmContactInfo.SetToViewModel).ToList<ContactInfoViewModel>();
        //    return contactInfoViewModel.AsQueryable();
        //}

        public ContactInfoViewModel GetContactInfo(int id)
        {
            var contactInfo = _iContactInfoRepository.GetById(id);
            var contactInfoViewModel = EmContactInfo.SetToViewModel(contactInfo);
            return contactInfoViewModel;
        }

        public IQueryable<ContactInfoViewModel> GetAll()
        {
            var contactInfos = _iContactInfoRepository.GetAll();
            var contactInfoViewModel = contactInfos.Select(EmContactInfo.SetToViewModel).ToList<ContactInfoViewModel>();
            return contactInfoViewModel.AsQueryable();
        }

        #endregion

        #region Create Method

        public int Create(ContactInfoViewModel contactInfoViewModel)
        {
            var contactInfo = EmContactInfo.SetToModel(contactInfoViewModel);
            _iContactInfoRepository.Insert(contactInfo);
            return Save();
        }

        #endregion

        #region Update Method

        public int Update(ContactInfoViewModel contactInfoViewModel)
        {
            var contactInfo = EmContactInfo.SetToModel(contactInfoViewModel);
            _iContactInfoRepository.Update(contactInfo);
            return Save();
        }

        #endregion

        #region Delete Method

        public int Delete(ContactInfoViewModel contactInfoViewModel)
        {
            var deleteContactInfo = GetContactInfo(contactInfoViewModel.ContactInfoId);
            var contactInfo = EmContactInfo.SetToModel(deleteContactInfo);
            _iContactInfoRepository.Delete(contactInfo);
            return Save();
        }

        #endregion

        #region Save By Commit

        //public void Save()
        //{
        //    _iUnitOfWork.Commit();
        //}

        public int Save()
        {
            return _iUnitOfWork.Commit();
        }

        #endregion
    }
}
