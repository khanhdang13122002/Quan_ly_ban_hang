using QuanLyBanHang.Models.EF;
using System.Linq;

namespace QuanLyBanHang.Models.DAO
{
    public class DashBoardDAO : BaseDao
    {
        public User getUser(int user_id)
        {
            return db_.Users.Where(us => us.userId.ToString().Contains(user_id.ToString())).FirstOrDefault();
        }
    }
}
