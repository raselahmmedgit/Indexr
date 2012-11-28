using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexr.Service
{
    public interface IGeneric<T> where T : class
    {
        //T GetById(long id);
        //T GetById(string id);
        IQueryable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        //void Delete(long id);
        //void Delete(string id);
        void Save();
    }
}
