using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Data;
using Indexr.Domain;

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

        //public IQueryable<ContactInfo> GetContactInfos()
        //{
        //    var contactInfos = _iContactInfoRepository.GetAll();
        //    return contactInfos.AsQueryable();
        //}

        public ContactInfo GetContactInfo(int id)
        {
            var contactInfo = _iContactInfoRepository.GetById(id);
            return contactInfo;
        }

        public IQueryable<ContactInfo> GetAll()
        {
            var contactInfos = _iContactInfoRepository.GetAll();
            return contactInfos.AsQueryable();
        }

        #endregion

        #region Create Method

        public void Create(ContactInfo contactInfo)
        {
            _iContactInfoRepository.Insert(contactInfo);
            Save();
        }

        #endregion

        #region Update Method
        
        public void Update(ContactInfo contactInfo)
        {
            _iContactInfoRepository.Update(contactInfo);
            Save();
        }

        #endregion

        #region Delete Method

        public void Delete(ContactInfo contactInfo)
        {
            var deleteContactInfo = GetContactInfo(contactInfo.ContactInfoId);
            _iContactInfoRepository.Delete(deleteContactInfo);
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
