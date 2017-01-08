using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentInfoDAL : BaseDAL<StudentInfo>
    {
        //#region MyRegion
        //DbContext dbContext = new MyContext();
        ////查多个
        //public IQueryable<StudentInfo> GetAllStudents(int pageSize, int pageIndex)
        //{
        //    return dbContext.Set<StudentInfo>().OrderByDescending(s => s.sId).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        //}
        ////查一个
        //public StudentInfo GetStudentById(int id)
        //{
        //    return dbContext.Set<StudentInfo>().Where(s => s.sId == id).FirstOrDefault();
        //}
        ////增
        //public int AddStudent(StudentInfo s)
        //{
        //    dbContext.Set<StudentInfo>().Add(s);
        //    return dbContext.SaveChanges();
        //}
        ////改
        //public int EditStudent(StudentInfo s)
        //{
        //    dbContext.Set<StudentInfo>().Attach(s);
        //    dbContext.Entry(s).State = System.Data.EntityState.Modified;
        //    return dbContext.SaveChanges();
        //}
        ////删
        //public int DeleteStudent(int id)
        //{
        //    //var stu = dbContext.Set<StudentInfo>().Where(s=>s.sId==id);
        //    //dbContext.Set<StudentInfo>().Remove(stu as StudentInfo);
        //    var stu = GetStudentById(id);
        //    dbContext.Set<StudentInfo>().Remove(stu);
        //    return dbContext.SaveChanges();
        //}

        //public override Expression<Func<StudentInfo, int>> GetKey()
        //{
        //    throw new NotImplementedException();
        //}

        //public override Expression<Func<StudentInfo, bool>> GetWithId(int id)
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion
        public override Expression<Func<StudentInfo, int>> GetKey()
        {
            return s => s.sId;
        }

        public override Expression<Func<StudentInfo, bool>> GetWithId(int id)
        {
            return s => s.sId == id;
        }
    }
}
