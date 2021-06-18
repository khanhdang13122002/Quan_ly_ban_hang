using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.Models.DAO
{
    public class ProductsDAO:BaseDao
    {
        public List<product> GetAll()
        {
            return db_.products.ToList();
        }

        public product GetProdByID(int id)
        {
            return db_.products.Where(t => t.productId == id).FirstOrDefault();
        }

        // Lấy name trong bảng category
        public List<category> GetCategoryName()
        {
            return db_.categories.ToList();
        }

        public void pages()
        {
            /*phan trang*/ /*cais nay toi se lam */
        }

        /*thêm*/
        public bool add(product info)
        {
            try
            {
                db_.products.Add(info);
                db_.SaveChanges();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        /*sửa*/
        public bool update(product prod)
        {
            try
            {
                var info = GetProdByID(prod.productId);
                if (info != null)
                {
                    info.image_ = prod.image_;
                    info.name = prod.name.Trim();
                    info.prices = prod.prices;
                    info.detail = prod.detail.Trim();
                    info.categoryId = prod.categoryId;

                    db_.SaveChanges();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        /*xóa*/
        public bool remove(product prod)
        {
            try
            {
                var getProd = GetProdByID(prod.productId);
                if (getProd != null)
                {
                    db_.products.Remove(getProd);
                    db_.SaveChanges();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
