using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentInfoBLL : BaseBLL<StudentInfo>
    {
        public override BaseDAL<StudentInfo> GetDAL()
        {
            return new StudentInfoDAL();
        }
    }
}
