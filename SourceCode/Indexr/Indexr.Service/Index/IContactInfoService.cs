using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Service
{
    public interface IContactInfoService : IGeneric<ContactInfo>
    {
        //IQueryable<ContactInfo> GetContactInfos();
        ContactInfo GetContactInfo(int id);
    }
}
