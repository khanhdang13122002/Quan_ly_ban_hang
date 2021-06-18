using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class UCProducts : UserControl
    {
        protected ProductsDAO products = new ProductsDAO();
        public UCProducts()
        {
            InitializeComponent();
            //loadProducts();
        }
        private void UCProducts_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        public void loadProducts()
        {
            /*sau nay se lam phan trang nên ông cứ để yên thôi ông chỉ cần them data bên sql sever nó sẽ tự load data ra cho ông*/
            foreach (var item in products.GetAll())
            {
                UCCard ucCard = new UCCard(item);
                tblProducts.Controls.Add(ucCard);
            }
        }

        /*btn add san pham*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductsEditor frm = new frmProductsEditor(null, true);
            frm.FormClosed += new FormClosedEventHandler(frm_closed);
            frm.Show();
        }

        /*sự kiện form closed*/
        private void frm_closed(object sender, FormClosedEventArgs e)
        {
            tblProducts.Controls.Clear();
            loadProducts();
        }

        private void tblProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
