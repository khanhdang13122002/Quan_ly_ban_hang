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

namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class frmProductsEditor : Form
    {
        protected bool isAdd_=true;
        public frmProductsEditor(product prd,bool isAdd)
        {
            InitializeComponent();
            if (isAdd)
            {
                lblTitle.Text = "Add";
                btnRemove.Enabled = false;
                btnRemove.Visible = false;
                btnAdd.Location = new Point((this.Width - btnAdd.Width) / 2,478);
            }
            else
            {
                loadData(prd);
                lblTitle.Text = "Update";
                btnAdd.Text = "Updated";
                btnAdd.Location = new Point(48,478);
                btnRemove.Enabled = true;
                btnRemove.Visible = true;

            }
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, 22);

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
            // load data to update;
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
        /*ham nay dung de convert image tu anh sang byte vi tren db se luu image bang byte*/
       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
