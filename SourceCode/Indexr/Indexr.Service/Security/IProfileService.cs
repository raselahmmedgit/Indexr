using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indexr.Domain;

namespace Indexr.Service
{
    public interface IProfileService : IGeneric<Profile>
    {
        //IQueryable<Profile> GetProfiles();
        Profile GetProfile(int id);
    }
}
