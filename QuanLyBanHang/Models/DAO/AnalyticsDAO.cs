using QuanLyBanHang.Models.EF;
using System.Linq;

namespace QuanLyBanHang.Models.DAO
{
    public class AnalyticsDAO : BaseDao
    {

        public int getCountProducts()
        {
            return db_.products.Count();
        }
        public int getCountUsers()
        {
            return db_.Users.Count();
        }
        public int getCountOrder()
        {
            return db_.order_.Count();
        }
        public int getCountHistories()
        {
            return db_.histories.Count();
        }
        /* ham tinh toan thoi gian*/


        /*lay lich su gan nhat theo time va truong*/
        public history getLastUpdatedOfProucts()
        {
            return db_.histories.OrderByDescending(his => his.time).Where(his => his.isProduct == true).FirstOrDefault();
        }
        public history getLastUpdateOfUser()
        {
            return db_.histories.OrderByDescending(his => his.time).Where(his => his.isUser == true).FirstOrDefault();

        }
        public history getLastUpdateOfOrder()
        {
            return db_.histories.OrderByDescending(his => his.time).Where(his => his.isOrder == true).FirstOrDefault();

        }
        public void note()
        {

        }
        public history getLastUpdateOfHis()
        {
            return db_.histories.OrderByDescending(his => his.time).FirstOrDefault();

        }
    }
}
