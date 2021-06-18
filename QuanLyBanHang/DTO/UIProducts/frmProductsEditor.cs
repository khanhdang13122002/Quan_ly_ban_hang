using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models.EF;
using QuanLyBanHang.Models.DAO;
using System.IO;
using QuanLyBanHang.DTO.UIMessage;

namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class frmProductsEditor : Form
    {
        protected frmSuccess msbSuccess = new frmSuccess();
        protected frmError mbsErr = new frmError();

        private bool mark;
        public bool Mark { get => mark; set => mark = value; }

        protected bool isAdd_ = true;

        private bool result = false;
        public bool Result { get { return result; } }

        public frmProductsEditor(product prd,bool isAdd)
        {
            InitializeComponent();
            if (isAdd)
            {
                Mark = true;
                lblTitle.Text = "Add";
                btnRemove.Enabled = false;
                btnRemove.Visible = false;
                btnAdd.Location = new Point((this.Width - btnAdd.Width) / 2,478);
                loadCbbCategory();
            }
            else
            {
                Mark = false;
                loadData(prd);
                lblTitle.Text = "Update";
                btnAdd.Text = "Updated";
                btnAdd.Location = new Point(48,478);
                btnRemove.Enabled = true;
                btnRemove.Visible = true;

            }
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 22);

        }

        // chuyển image sang byte để save vào db (phục vụ cho chức năng THÊM sp)
        byte[] ConvertImage(Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
        }

        // convert image từ ảnh sang byte (vì db sẽ lưu ảnh bằng byte)
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string filePath = "";
            if (open.FileName != null)
            {
                if (filePath != open.FileName)
                {
                    filePath = open.FileName;
                    ptbProductPic.Image = Image.FromFile(filePath);
                }
            }
        }

        // load data để edit
        void loadData(product products)
        {
            ptbProductPic.Image = null;
            txtName.Text = products.name;
            txtPrices.Text = products.prices.ToString();
            txtDeitail.Text = products.detail;
            loadCbbCategory();
        }
        
        // đổ dữ liệu ra cbbCategory
        private void loadCbbCategory()
        {
            ProductsDAO dao = new ProductsDAO();
            // đổ data vào combobox
            cbbCategory.DisplayMember = "name";
            cbbCategory.ValueMember = "categoryId";
            cbbCategory.DataSource = dao.GetCategoryName();
        }

        // Lưu thông tin được sửa hoặc sản phẩm thêm mới
        private product InitProductsInfo()
        {
            product prod = new product();
            prod.image_ = null;
            prod.name = txtName.Text.Trim();
            prod.prices = Convert.ToInt32(txtPrices.Text.Trim());
            prod.detail = txtDeitail.Text.Trim();
            prod.categoryId = (int)cbbCategory.SelectedValue;

            return prod;
        }

        // Lưu sau khi thêm hoặc sửa
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductsDAO dao = new ProductsDAO();
            product getData = InitProductsInfo();
            if (Mark)
            {
                if (dao.add(getData))
                {
                    msbSuccess.show_("Thêm Thành Công");
                    result = true;
                    this.Close();
                }  
                else
                    mbsErr.show_("Thêm Thất Bại");
            } else
            {
                if (dao.update(getData))
                {
                    msbSuccess.show_("Sửa Thành Công");
                    result = true;
                    this.Close();
                }   
                else
                    mbsErr.show_("Sửa Thất Bại");
            }
        }

        // đóng form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // xóa sp
        private void btnRemove_Click(object sender, EventArgs e)
        {
            ProductsDAO dao = new ProductsDAO();
            product getData = InitProductsInfo();
            if (!Mark && getData != null)
            {
                if (dao.remove(getData))
                {
                    msbSuccess.show_("Xóa Thành Công");
                    result = true;
                    this.Close();
                } else
                {
                    mbsErr.show_("Xóa Thất Bại");
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
