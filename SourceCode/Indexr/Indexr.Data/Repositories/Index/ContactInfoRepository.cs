using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Data
{
    public class ContactInfoRepository : RepositoryBase<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(IDatabaseFactory iDatabaseFactory)
            : base(iDatabaseFactory)
        {
        }

    }

    public interface IContactInfoRepository : IRepositoryBase<ContactInfo>
    {

    }
}
