using QuanLyBanHang.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyBanHang.Models.DAO
{
    public class ProductsDAO : BaseDao
    {

        public product GetProductById(int id)
        {
            return db_.products.Where(pr => pr.productId == id).FirstOrDefault();
        }
        public List<product> GetAll()
        {
            return db_.products.ToList();
        }
        public List<category> getCategory()
        {

            return db_.categories.ToList();
        }
        public int getMaxId()
        {
            var reslut = db_.products.OrderByDescending(prd => prd.productId).FirstOrDefault();
            return reslut.productId;
        }
        public List<product> pages(string key, int page, int limit = 8)
        {
            var category = db_.categories.Where(ca => ca.name.Contains(key)).FirstOrDefault();
            if (key == null)
            {
                return db_.products.OrderBy(pr => pr.productId).Skip((page - 1) * limit).Take(limit).ToList();

            }
            else
            {
                if (category != null)
                {
                    return db_.products.Where(pr => pr.categoryId == category.categoryId || pr.name.Contains(key)).OrderBy(pr => pr.productId).Skip((page - 1) * limit).Take(limit).ToList();
                }
                else
                {
                    return db_.products.Where(pr => pr.name.Contains(key)).OrderBy(pr => pr.productId).Skip((page - 1) * limit).Take(limit).ToList();
                }

            }
        }
        public int TotalRecord()
        {
            return db_.products.Count();
        }
        public bool add(product prd, int id)
        {
            try
            {
                db_.products.Add(prd);
                db_.SaveChanges();
                addHis(id, "Them San Pham", true);
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
        public bool update(product prd, int id)
        {
            var prd_ = db_.products.Where(pr => pr.productId == prd.productId).ToList();
            try
            {
                foreach (var item in prd_)
                {
                    item.name = prd.name;
                    item.prices = prd.prices;
                    item.detail = prd.detail;
                    if (item.image_ != prd.image_)
                    {
                        item.image_ = prd.image_;
                    }
                    item.categoryId = prd.categoryId;
                }
                db_.SaveChanges();
                addHis(id, "Sua San Pham", true);

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
        public bool remove(int id)
        {
            var prd = GetProductById(id);
            try
            {
                db_.products.Remove(prd);
                db_.SaveChanges();
                addHis(id, "Xoa San Pham", true);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool addHis(int user_id, string action_, bool isProduct_)
        {
            try
            {
                hisDao hisDao_ = new hisDao();
                DateTime time_ = DateTime.Now;
                int hisId = hisDao_.getMaxId();
                history newHis = new history
                {
                    historyId = hisId + 1,
                    time = time_,
                    userId = user_id,
                    action = action_,
                    isProduct = isProduct_
                };
                bool result = hisDao_.addHis(newHis);
                if (result)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
