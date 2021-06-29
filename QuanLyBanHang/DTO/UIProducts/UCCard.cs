﻿using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class UCCard : UserControl
    {
        protected product prd;
        int id_;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse

       );
        public UCCard(product products, int id)
        {
            InitializeComponent();
            id_ = id;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 6, 6));
            LoadData(products);
            prd = products;
            // gọi hàm load data truyền vào 1 product khi load
        }
        void LoadData(product products)// hd nàm này nhận 1 đối tượng product . tôi đag làm cái designn của thêm sửa xóa ( có 2 option 1 là click vào card nó sẽ hiện lên chức năng sửa có 1 nút add , nút info se có chức năng show thông tin)
        {

            if (products != null)
            {
                this.lblName.Text = products.name.Trim();
                this.lblPrices.Text = products.prices.ToString() + "$";
                this.ptbPic.Image = null;
                lblName.Location = new Point((this.Width - lblName.Width) / 2, 126);
                lblPrices.Location = new Point((this.Width - lblPrices.Width) / 2, 146);
                loadImage(products.image_);
            }

            //load data of products

        }

        void loadEditForm(product product)
        {
            frmProductsEditor frm = new frmProductsEditor(product, false, id_);
            frm.FormClosed += new FormClosedEventHandler(frm_Closed);
            frm.Show();

        }

        void loadImage(byte[] img)
        {
            ptbPic.Image = ByteArrayToImage(img);
        }

        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            ProductsDAO prdDao = new ProductsDAO();

            LoadData(prdDao.GetProductById(prd.productId));
        }

        private void UCCard_Click(object sender, EventArgs e)
        {
            /*khi click thi se goi update*/
            //some action here.
            ProductsDAO prdDao = new ProductsDAO();

            loadEditForm(prdDao.GetProductById(prd.productId));

        }
        /*    chuyen byte sang image de show*/
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

        private void UCCard_Load(object sender, EventArgs e)
        {

        }
    }
}
