using QuanLyBanHang.DTO.UIMessage;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class frmProductsEditor : Form
    {
        protected bool isAdd_ = true;
        protected int id_;
        protected product product_;
        protected ProductsDAO prdDao_ = new ProductsDAO();
        protected frmSuccess success = new frmSuccess();
        protected frmError erorr = new frmError();

        public frmProductsEditor(product prd, bool isAdd, int id)
        {
            InitializeComponent();
            id_ = id;
            if (isAdd)
            {
                lblTitle.Text = "Thêm";

                btnAdd.Location = new Point((this.Width - btnAdd.Width) / 2, 478);
            }
            else
            {
                loadData(prd);
                lblTitle.Text = "Sửa Sản Phẩm";
                btnAdd.Text = "Sửa";
                btnAdd.Location = new Point((this.Width - btnAdd.Width) / 2, 478);
                isAdd_ = false;

            }
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 22);
            loadCategories();
            product_ = prd;
        }
        /*chuyen image sang byte de save vao db*/
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
        void loadData(product products)
        {
            txtDeitail.Text = products.detail;
            txtName.Text = products.name;
            txtPrices.Text = products.prices.ToString();
            ptbProductPic.Image = ByteArrayToImage(products.image_);

        }
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


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadCategories()
        {
            cbbCategory.DisplayMember = "name";
            cbbCategory.ValueMember = "categoryId";
            cbbCategory.DataSource = prdDao_.getCategory();
        }

        public void add()
        {
            int id = prdDao_.getMaxId();
            product prd = new product
            {

                productId = id + 1,
                name = txtName.Text.Trim(),
                prices = int.Parse(txtPrices.Text.Trim()),
                categoryId = int.Parse(cbbCategory.SelectedValue.ToString()),
                detail = txtDeitail.Text.Trim(),
                image_ = ConvertImage(ptbProductPic.Image),
                userId = null
            };
            bool checkAdd = prdDao_.add(prd, id_);
            if (checkAdd)
            {
                success.show_("Thêm Thành Công");
            }
            else
            {
                erorr.show_("Thêm Thất Bại");
            }
        }
        public void update()
        {
            product prd = new product
            {
                productId = product_.productId,
                name = txtName.Text.Trim(),
                prices = int.Parse(txtPrices.Text.Trim()),
                categoryId = int.Parse(cbbCategory.SelectedValue.ToString()),
                detail = txtDeitail.Text.Trim(),
                image_ = ConvertImage(ptbProductPic.Image),
                userId = null
            };
            bool checkUpdate = prdDao_.update(prd, id_);
            if (checkUpdate)
            {
                if (success.show_("Sửa Thành Công") == DialogResult.OK) { this.Close(); };
            }
            else
            {
                if (erorr.show_("Sửa Không Thành Công") == DialogResult.OK) { this.Close(); };
            }
        }

        public Image ByteArrayToImage(byte[] byteArr)
        {
            if (byteArr != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArr))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            else
            {
                return null;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isAdd_)
            {
                add();
            }
            else
            {
                update();
            }
        }
    }
}
