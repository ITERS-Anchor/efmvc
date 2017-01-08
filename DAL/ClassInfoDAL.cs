using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassInfoDAL : BaseDAL<ClassInfo>
    {
        #region 没加封装 
        //    DbContext dbContext = new MyContext();
        //    //查多个
        //    public IQueryable<ClassInfo> GetAllClasses(int pageSize, int pageIndex)
        //    {
        //        return dbContext.Set<ClassInfo>().OrderByDescending(c => c.cId).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        //    }
        //    //查一个
        //    public ClassInfo GetClassById(int id)
        //    {
        //        return dbContext.Set<ClassInfo>().Where(c => c.cId == id).FirstOrDefault();
        //    }
        //    //增
        //    public int AddClass(ClassInfo c)
        //    {
        //        dbContext.Set<ClassInfo>().Add(c);
        //        return dbContext.SaveChanges();
        //    }
        //    //改
        //    public int EditClass(ClassInfo c)
        //    {
        //        dbContext.Set<ClassInfo>().Attach(c);
        //        dbContext.Entry(c).State = System.Data.EntityState.Modified;
        //        return dbContext.SaveChanges();
        //    }
        //    //删
        //    public int DeleteClass(int id)
        //    {
        //        //var stu = dbContext.Set<StudentInfo>().Where(s=>s.sId==id);
        //        //dbContext.Set<StudentInfo>().Remove(stu as StudentInfo);
        //        var cla = GetClassById(id);
        //        dbContext.Set<ClassInfo>().Remove(cla);
        //        return dbContext.SaveChanges();
        //    }

        //    public override Expression<Func<ClassInfo, int>> GetKey()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public override Expression<Func<ClassInfo, bool>> GetWithId(int id)
        //    {
        //        throw new NotImplementedException();
        //    }
        #endregion

        public override Expression<Func<ClassInfo, int>> GetKey()
        {
            return c => c.cId;
        }

        public override Expression<Func<ClassInfo, bool>> GetWithId(int id)
        {
            return c => c.cId == id;
        }
    }
}
