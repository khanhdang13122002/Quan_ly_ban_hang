using QuanLyBanHang.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyBanHang.Models.DAO
{
    public class hisDao : BaseDao
    {
        public List<history> getAll()
        {
            return db_.histories.OrderByDescending(his => his.time).ToList();
        }
        public List<history> getAllByProducts()
        {
            return db_.histories.OrderByDescending(his => his.time).Where(his => his.isProduct == true).ToList();
        }
        public List<history> getAllByUsers()
        {
            return db_.histories.OrderByDescending(his => his.time).Where(his => his.isUser == true).ToList();
        }
        public List<history> getAllByOrder()
        {
            return db_.histories.OrderByDescending(his => his.time).Where(his => his.isOrder == true).ToList();
        }
        public int getMaxId()
        {
            var result = db_.histories.OrderByDescending(his => his.historyId).FirstOrDefault();
            return result.historyId;
        }
        public bool addHis(history his)
        {
            try
            {
                db_.histories.Add(his);
                db_.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
