using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.Models.DAO
{
   public class DashBoardDAO:BaseDao
    {
        public Users getUser(int user_id)
        {
            return db_.Users.Where(us => us.userId.ToString().Contains(user_id.ToString())).FirstOrDefault();
        }
    }
}
