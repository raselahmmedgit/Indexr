using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Data
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(IDatabaseFactory iDatabaseFactory)
            : base(iDatabaseFactory)
        {
        }

    }
    
    public interface IRoleRepository : IRepositoryBase<Role>
    {

    }
}
