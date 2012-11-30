using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Data
{
    public class ProfileRepository : RepositoryBase<Profile>, IProfileRepository
    {
        public ProfileRepository(IDatabaseFactory iDatabaseFactory)
            : base(iDatabaseFactory)
        {
        }

    }

    public interface IProfileRepository : IRepositoryBase<Profile>
    {

    }
}
