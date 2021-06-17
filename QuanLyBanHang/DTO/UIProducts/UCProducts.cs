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
        protected int currentPage = 1;
        protected ProductsDAO products = new ProductsDAO();
        protected int totalRecord = 0;

        public UCProducts()
        {
            InitializeComponent();
            loadProducts(products.pages(null, currentPage));
            loadPage();
        }
        public void loadPage()
        {
            totalRecord = products.TotalRecord();
            lblCurrentPage.Text = currentPage.ToString();
            lblTotalPage.Text =((totalRecord / 8)+1).ToString();
        }
        public void loadProducts(List<product>product)
        {

            /*sau nay se lam phan trang nên ông cứ để yên thôi ông chỉ cần them data bên sql sever nó sẽ tự load data ra cho ông*/
            foreach (var item in product)
            {
                UCCard ucCard = new UCCard(item);
                tblProducts.Controls.Add(ucCard);
            }

        }

        private void tblProducts_Paint(object sender, PaintEventArgs e)
        {

        }
     /*   btn add san pham*/
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
            loadProducts(products.pages(null, currentPage));
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            totalRecord = products.TotalRecord();
            if (currentPage - 1 > 0)
            {
               -- currentPage;
                loadPage();
                tblProducts.Controls.Clear();
                loadProducts(products.pages(null, currentPage));

            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage - 1 < (totalRecord / 8))
            {
                ++ currentPage;
                loadPage();
                tblProducts.Controls.Clear();
                loadProducts(products.pages(null, currentPage));
            }
        }
    }
}
