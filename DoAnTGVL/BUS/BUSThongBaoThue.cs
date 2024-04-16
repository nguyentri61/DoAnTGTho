using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DoAnTGVL.BUS
{
    class BUSThongBaoThue
    {
        DAODSCongViec dAODSCongViec = new DAODSCongViec();
        public void CreateWrapThongBao(Tho tho, ThongBaoThue thongBaoThue)
        {
            UserControl userControl = new UserControl();
            thongBaoThue.wrapTbao.Children.Clear();
            List<CongViec> congViecs = dAODSCongViec.ReadAllDSThueTho(tho.Id, "Chờ xác nhận");
            foreach (CongViec congViec in congViecs)
            {
                userControl = new UCTBaoThue(congViec);
                userControl.Height = 250;
                userControl.Width = 600;
                userControl.Margin = new Thickness(35);
                thongBaoThue.wrapTbao.Children.Add(userControl);
            }
        }
    }
}
