﻿using QuanLyBanHang.Models.DAO;
using QuanLyBanHang.Models.EF;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.DTO.UIAnalytics
{
    public partial class UCAnalytics : UserControl
    {
        protected AnalyticsDAO analyticsDao = new AnalyticsDAO();
        public UCAnalytics(int auth_id)
        {
            InitializeComponent();
            /* animation*/
            this.cpbOrderPrecent.Value = 0;
            this.cpbProductsPercent.Value = 0;
            /* animation*/
            productsHis();
            usersHis();
            orderHis();
            His();
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
        void productsHis()
        {
            var his = analyticsDao.getLastUpdatedOfProucts();
            lblHis.Text = his.time.ToString();
        }
        void usersHis()
        {
            history orderHis = analyticsDao.getLastUpdateOfOrder();
            var his = analyticsDao.getLastUpdateOfUser();
            lblUserHis.Text = his.time.ToString();
        }
        void orderHis()
        {
            var his = analyticsDao.getLastUpdateOfOrder();
            lblOrderHis.Text = his.time.ToString();
        }
        public void loadNote(int id)
        {
            //chưa cập nhât
        }
        void His()
        {
            history His = analyticsDao.getLastUpdateOfHis();
            var his = analyticsDao.getLastUpdateOfHis();
            lblHistories.Text = his.time.ToString();
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
