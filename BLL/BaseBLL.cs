using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BaseBLL<T>
        where T : class
    {
        //BaseDAL<T> dal = new BaseDAL<T>();
        private BaseDAL<T> dal;
        public BaseBLL()
        {
            dal = GetDAL();
        }
        public abstract BaseDAL<T> GetDAL();
        public IQueryable<T> GetAll()
        {
            return dal.GetAll();
        }
        public IQueryable<T> GetPageList(int pageSize, int pageIndex)
        {
            return dal.GetPageList(pageSize, pageIndex);
        }
        public T GetById(int id)
        {
            return dal.GetById(id);
        }
        public int Add(T s)
        {
            return dal.Add(s);
        }
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        public int Edit(T s)
        {
            return dal.Edit(s);
        }
    }
}
