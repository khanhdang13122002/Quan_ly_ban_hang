using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.Models.DAO
{
    public class BaseDao
    {
        protected Models.EF.QuanLyBanHangEntities db_;
        public BaseDao()
        {
            db_ = new QuanLyBanHangEntities();
        }
    }
}
