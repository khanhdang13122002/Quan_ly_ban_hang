using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.Models.DAO
{
    public class AnalyticsDAO:BaseDao
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
        public int[] Time(history his)
        {
            string day_his="", month_his="", year_his="";
            string day_now="", month_now="", year_now="";
            string time_now = DateTime.Now.ToString();
            string time_his = his.time.ToString();
            int count = 0;
            for(int i = 0; i < 10; i++)
            {
                if (time_his[i] == '/')
                {
                    ++count;
                    continue;
                }
                if (count == 0)
                {
                    day_his += time_his[i].ToString();
                    day_now += time_now[i].ToString();
                }
               
                if (count == 1)
                {
                    month_his+= time_his[i].ToString();
                    month_now += time_now[i].ToString();
                }
                if (count == 2)
                {
                    year_his+= time_his[i].ToString();
                    year_now += time_now[i].ToString();
                }
            }

            int[] time_ = {19,02,2002};
            return time_;
        }
       /*lay lich su gan nhat theo time va truong*/
        public history getLastUpdatedOfProucts()
        {
            return db_.histories.OrderByDescending(his => his.time).ThenByDescending(his => his.isProduct).FirstOrDefault();
        }
    }
}
