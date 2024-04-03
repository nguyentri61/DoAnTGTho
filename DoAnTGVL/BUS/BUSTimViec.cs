using DoAnTGVL.Class;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using DoAnTGVL.DAO;

namespace DoAnTGVL.BUS
{
    class BUSTimViec
    {
        DAOBaiDang dAOBaiDang = new DAOBaiDang();

        public void CreateWrapBaiDang(FilterBaiDang filterBaiDang, UCTimViec uctimviec)
        {
            uctimviec.WpanelDanhS.Children.Clear();
            List<BaiDang> DSbaiDang = dAOBaiDang.FilterBaiDang(filterBaiDang);
            UserControl userControl;

            foreach (BaiDang baidang in DSbaiDang)
            {
                userControl = new UCDanhSachCongViec(baidang, uctimviec.tho);
                userControl.Width = 620;
                userControl.Height = 370;
                userControl.Margin = new Thickness(10);
                // Thêm UserControl vào WrapPanel
                uctimviec.WpanelDanhS.Children.Add(userControl);
            }
        }
    }
}
