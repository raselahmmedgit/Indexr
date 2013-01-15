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

namespace Indexr.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _iDatabaseFactory;
        private AppDbContext _dataContext;

        public UnitOfWork(IDatabaseFactory iDatabaseFactory)
        {
            this._iDatabaseFactory = iDatabaseFactory;
        }

        protected AppDbContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _iDatabaseFactory.Get()); }
        }

        //public void Commit()
        //{
        //    DataContext.SaveChanges();
        //}

        public int Commit()
        {
            return DataContext.SaveChanges();
        }
    }
}
