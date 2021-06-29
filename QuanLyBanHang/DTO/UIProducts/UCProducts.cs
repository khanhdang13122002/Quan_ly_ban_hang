using QuanLyBanHang.DTO.UILoading;
using QuanLyBanHang.DTO.UIMessage;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class UCProducts : UserControl
    {
        int id_;
        protected frmSuccess success = new frmSuccess();
        protected frmError error = new frmError();
        protected int currentPage = 1;
        protected int totalRecord = 0;
        string key_ = "";
        public UCProducts(string key, int id)
        {
            InitializeComponent();
            id_ = id;
            ProductsDAO products = new ProductsDAO();
            key_ = key;
            loadProducts(products.pages(key, currentPage));
            loadPage();
        }
        public void loadPage()
        {

            ProductsDAO products = new ProductsDAO();
            totalRecord = products.TotalRecord();
            lblCurrentPage.Text = currentPage.ToString();
            lblTotalPage.Text = ((totalRecord / 8) + 1).ToString();
        }
        public void showLoading()
        {
            frmLoading loading = new frmLoading();
            loading.ShowDialog();
        }
        public void loadProducts(List<product> product)
        {
            Thread thr = new Thread(showLoading);
            thr.Start();
            if (product?.Any() != true)
            {


                tblProducts.Controls.Clear();
                Label lblEmpty = new Label();
                lblEmpty.Text = "Không Tìm Thấy Sản Phẩm Nào!..";
                lblEmpty.Location = new Point((tblProducts.Width - lblEmpty.Width) / 2, (tblProducts.Height - lblEmpty.Height) / 2);
                tblProducts.Controls.Add(lblEmpty);
            }
            else
            {
                foreach (var item in product)
                {
                    UCCard ucCard = new UCCard(item, id_);
                    ucCard.btnRemove.Click += new EventHandler((sender, e) => btnRemove_click(sender, e, item.productId));
                    tblProducts.Controls.Add(ucCard);
                }
            }
            /*sau nay se lam phan trang nên ông cứ để yên thôi ông chỉ cần them data bên sql sever nó sẽ tự load data ra cho ông*/

            thr.Abort();
        }
        public void Remove(int id)
        {

            ProductsDAO products = new ProductsDAO();

            bool checkRemove = products.remove(id);
            if (checkRemove)
            {
                if (success.show_("Xóa Thành Công!") == DialogResult.OK)
                {
                    ProductsDAO prdDao_ = new ProductsDAO();
                    tblProducts.Controls.Clear();
                    loadProducts(prdDao_.pages(null, currentPage));
                }
            }
            else
            {
                error.show_("Xóa Thất Bại!");
            }
        }

        private void btnRemove_click(object sender, EventArgs e, int id)
        {

            Remove(id);
        }

        private void tblProducts_Paint(object sender, PaintEventArgs e)
        {

        }
        /*   btn add san pham*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductsEditor frm = new frmProductsEditor(null, true, id_);
            frm.FormClosed += new FormClosedEventHandler(frm_closed);
            frm.Show();
        }
        /*sự kiện form closed*/
        private void frm_closed(object sender, FormClosedEventArgs e)
        {
            ProductsDAO products = new ProductsDAO();

            tblProducts.Controls.Clear();
            loadProducts(products.pages(key_, currentPage));
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ProductsDAO products = new ProductsDAO();

            totalRecord = products.TotalRecord();
            if (currentPage - 1 > 0)
            {
                --currentPage;
                loadPage();
                tblProducts.Controls.Clear();
                loadProducts(products.pages(key_, currentPage));

            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ProductsDAO products = new ProductsDAO();

            if (currentPage - 1 < (totalRecord / 8))
            {
                ++currentPage;
                loadPage();
                tblProducts.Controls.Clear();
                loadProducts(products.pages(key_, currentPage));
            }
        }
    }
}
