using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;

namespace QuanLyBanHang.DTO.UIAnalytics
{
    public partial class UCAnalytics : UserControl
    {
        protected AnalyticsDAO analyticsDao = new AnalyticsDAO();
        public UCAnalytics()
        {
            InitializeComponent();
           /* animation*/
            this.cpbOrderPrecent.Value = 0;
            this.cpbProductsPercent.Value = 0;
            /* animation*/
            checkTime();

        }

        /* animation*/
        private void oderPercentTimer_Tick(object sender, EventArgs e)
        {
            cpbOrderPrecent.Value += 1;
            if (cpbOrderPrecent.Value == 56)
            {
                oderPercentTimer.Enabled = false;
            }
        }
        /* animation*/
        public void loadData()
        {
           /* Load du lieu*/
            lblTotalProducts.Text = analyticsDao.getCountProducts().ToString();
            lblTotalUsers.Text = analyticsDao.getCountUsers().ToString();
            lblOrderTotal.Text = analyticsDao.getCountOrder().ToString();
            lblHisChangeTotal.Text = analyticsDao.getCountHistories().ToString();
            /* Load du lieu*/
        }
        /*  chuc nang cap nhat lich su*/
        void checkTime()
        {
            history hisProducts = analyticsDao.getLastUpdatedOfProucts();
            int[] time_ = analyticsDao.Time(hisProducts);
           
            if (time_[0] >= 1)
            {
                lblHis.Text = "Updated for " + time_[0].ToString() + " days";
            }
            if (time_[1] >= 1)
            {
                lblHis.Text = "Updated for " + time_[1].ToString() + " Months";
            }
            if (time_[2] >= 1)
            {
                lblHis.Text = "Updated for " + time_[2].ToString() + " Years";
            }
        }
        /*  chuc nang cap nhat lich su*/

        private void UCAnalytics_Load(object sender, EventArgs e)
        {
            loadData();
        }
  /*      animation thooi*/
        private void productTimer_Tick(object sender, EventArgs e)
        {
            cpbProductsPercent.Value += 1;
            productTimer.Interval = 20;
            if (cpbProductsPercent.Value == 72)
            {
                productTimer.Enabled = false;
            }
        }
        /*      animation thooi*/
    }
}
