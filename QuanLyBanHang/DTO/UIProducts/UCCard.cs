using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.DTO.UIProducts
{
    public partial class UCCard : UserControl
    {
        protected product prd;
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

        public UCCard(product products)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 6, 6));
            LoadData(products);
            prd = products;
            // gọi hàm load data truyền vào 1 product khi load
        }

        void LoadData(product products)// hd nàm này nhận 1 đối tượng product . tôi đag làm cái designn của thêm sửa xóa ( có 2 option 1 là click vào card nó sẽ hiện lên chức năng sửa có 1 nút add , nút info se có chức năng show thông tin)
        {
            this.lblName.Text = products.name.Trim();
            this.lblPrices.Text = products.prices.ToString() + "$";
            this.ptbPic.Image = null;
            lblName.Location = new Point((this.Width - lblName.Width) / 2, 126);
            lblPrices.Location = new Point((this.Width - lblPrices.Width) / 2, 146);
            //load data of products
        }
        
        void loadEditForm(product product)
        {
            frmProductsEditor frm = new frmProductsEditor(product, false);
            frm.FormClosed += new FormClosedEventHandler(frm_Closed);
            frm.Show();
            if (frm.Result)
            {
                LoadData(product);
            }
        }

        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            LoadData(prd);
        }

        // khi click thi se goi update
        private void UCCard_Click(object sender, EventArgs e)
        { 
            //some action here.
            loadEditForm(prd);

        }

        //chuyển byte sang image để show
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
            LoadData(prd);
        }

        // hiển thị thông tin chi tiết của sp
        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmProductDetail frm = new frmProductDetail();
            frm.ProID = prd.productId;
            frm.ShowDialog();
        }
    }
}
