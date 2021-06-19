using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.Models.DAO
{
    public class ProductsDAO:BaseDao
    {
        
        public product GetProductById(int id)
        {
            return db_.products.Where(pr => pr.productId == id).FirstOrDefault();
        }
        public List<product> GetAll()
        {
            return db_.products.ToList();
        }
        public List<category> getCategory() {

            return db_.categories.ToList();
        }
        public int getMaxId()
        {
            var reslut= db_.products.OrderByDescending(prd => prd.productId).FirstOrDefault();
            return reslut.productId;
        }
        public List<product> pages(string key,int page,int limit=8)
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
                    return db_.products.Where(pr => pr.categoryId == category.categoryId).OrderBy(pr => pr.productId).Skip((page - 1) * limit).Take(limit).ToList();
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
        public bool add(product prd)
        {
            try
            {
                db_.products.Add(prd);
                db_.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;

            }
        }
        public bool update(product prd)
        {
            var prd_ = db_.products.Where(pr => pr.productId == prd.productId).ToList();
            try
            {
                foreach(var item in prd_)
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
                return true;
            }catch(Exception ex)
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }
}
