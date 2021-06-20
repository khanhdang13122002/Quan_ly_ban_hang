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
            if (his != null)
            {
                string day_his = "", month_his = "", year_his = "";
                string day_now = "", month_now = "", year_now = "";
                string time_now = DateTime.Now.ToString();
                string time_his = his.time.ToString();
                int count = 0;
                for (int i = 0; i < 10; i++)
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
                        month_his += time_his[i].ToString();
                        month_now += time_now[i].ToString();
                    }
                    if (count == 2)
                    {
                        year_his += time_his[i].ToString();
                        year_now += time_now[i].ToString();
                    }
                }
                int day = int.Parse(day_now) - int.Parse(day_his);
                int month = int.Parse(month_now) - int.Parse(month_his);
                int year = int.Parse(year_now) - int.Parse(year_his);
                int[] time_ = { day, month, year };
                return time_;
            } else
            {
                return null;
            }
        }
       /*lay lich su gan nhat theo time va truong*/
        public history getLastUpdatedOfProucts()
        {
            return db_.histories.OrderBy(his => his.time).Where(his=>his.isProduct==true).FirstOrDefault();
        }
        public history getLastUpdateOfUser()
        {
            return db_.histories.OrderBy(his => his.time).Where(his => his.isUser == true).FirstOrDefault();

        }
        public history getLastUpdateOfOrder()
        {
            return db_.histories.OrderBy(his => his.time).Where(his => his.isOrder == true).FirstOrDefault();

        }
        public void note()
        {

        }
        public history getLastUpdateOfHis()
        {
            return db_.histories.OrderBy(his => his.time).FirstOrDefault();

        }
    }
}
