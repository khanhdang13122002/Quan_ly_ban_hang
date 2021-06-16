using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.Models.DAO
{
    public class BaseDao
    {
        protected Models.EF.QuanLyBanHangEntities3 db_;
        public BaseDao()
        {
            db_ = new QuanLyBanHangEntities3();
        }
    }
}
