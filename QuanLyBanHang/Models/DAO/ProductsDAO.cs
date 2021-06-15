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
        public List<products> GetAll()
        {
            return db_.products.ToList();
        }
        public void pages()
        {
            /*phan trang*/ /*cais nay toi se lam */
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
