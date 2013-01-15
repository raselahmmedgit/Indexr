﻿/****************** Copyright Notice *****************
 
This code is licensed under Microsoft Public License (Ms-PL). 
You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:

=======================================================
   
Designed and Implemented By:
Rasel Ahmmed
Software Engineer, I Like .NET
Twitter: http://twitter.com/raselbappi | Blog: http://springsolution.net | About Me: http://springsolution.net/about-me/
   
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;

namespace Indexr.Data
{
    public abstract class RepositoryBase<T> where T : class
    {
        private AppDbContext _dataContext;

        private readonly IDbSet<T> _iDbSet;
       
        protected RepositoryBase(IDatabaseFactory iDatabaseFactory)
        {
            _iDatabaseFactory = iDatabaseFactory;
            _iDbSet = DataContext.Set<T>();
        }

        protected IDatabaseFactory _iDatabaseFactory
        {
            get;
            private set;
        }

        protected AppDbContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _iDatabaseFactory.Get()); }
        }

        public virtual void Insert(T entity)
        {
            _iDbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _iDbSet.Attach(entity);
            _dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _iDbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _iDbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                _iDbSet.Remove(obj);
        }

        public virtual T GetById(long id)
        {
            return _iDbSet.Find(id);
        }

        public virtual T GetById(string id)
        {
            return _iDbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _iDbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _iDbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _iDbSet.Where(where).FirstOrDefault<T>();
        }
       
    }
}
