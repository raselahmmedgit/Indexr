using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexr.Data
{
    public interface IDatabaseFactory : IDisposable
    {
        AppDbContext Get();
    }
}
