using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class frmProductDetail : Form
    {
        protected product prd;
        private int proID;

        public int ProID { get => proID; set => proID = value; }

        public frmProductDetail()
        {
            InitializeComponent();
        }

        // load dữ liệu ban đầu
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            loadData(prd);
        }

        // load data to update
        void loadData(product product)
        {
            ProductsDAO dao = new ProductsDAO();
            var info = dao.GetProdByID(proID);
            txtName.Text = info.name;
            txtPrices.Text = info.prices.ToString();
            txtDeitail.Text = info.detail;
            txtCategoryName.Text = info.category.name;
        }

        // đóng form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
