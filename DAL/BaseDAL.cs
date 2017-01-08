using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseDAL<T>
        where T : class
    {
        DbContext dbContext = new MyContext();
        //查多个
        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }
        public IQueryable<T> GetPageList(int pageSize, int pageIndex)
        {//OrderByDescending(GetKey())
            return dbContext.Set<T>().OrderBy(GetKey()).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        //查一个
        public T GetById(int id)
        {
            return dbContext.Set<T>().Where(GetWithId(id)).FirstOrDefault();
        }
        //增
        public int Add(T s)
        {
            dbContext.Set<T>().Add(s);          
            return dbContext.SaveChanges();            
        }
        //删
        public int Delete(int id)
        {
            var m = GetById(id);
            dbContext.Set<T>().Remove(m);
            return dbContext.SaveChanges();
        }
        //改
        public int Edit(T s)
        {
            dbContext.Set<T>().Attach(s);
            dbContext.Entry(s).State = EntityState.Modified;
            return dbContext.SaveChanges();

        }
        public abstract Expression<Func<T, int>> GetKey();
        public abstract Expression<Func<T, bool>> GetWithId(int id);
    }
}
