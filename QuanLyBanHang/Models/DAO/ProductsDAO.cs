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
        public List<product> GetAll()
        {
            return db_.products.ToList();
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
                    return db_.products.Where(pr => pr.name.Contains(key) || pr.productId == int.Parse(key) || pr.categoryId == category.categoryId).OrderBy(pr => pr.productId).Skip((page - 1) * limit).Take(limit).ToList();
                }
                else
                {
                    return db_.products.Where(pr => pr.name.Contains(key) || pr.productId == int.Parse(key)).OrderBy(pr => pr.productId).Skip((page - 1) * limit).Take(limit).ToList();
                }
            }
        }
        public int TotalRecord()
        {
            return db_.products.Count();
        }
        public bool add()
        {
            /*them*/
            return false;
        }
        public bool update()
        {
            /*sua*/
            return false;
        }
        public bool remove()
        {
            /*xoa*/
            return false;
        }
        
    }
}
