using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace DoAnTGVL.BUS
{

    public class BUSThueTho
    {
        DAOTho dAOTho = new DAOTho();
        UserControl userControl;
        public void CreateWrapThueTho(FilterTho filterTho,User user, UCThueTho uCThueTho)
        {
            uCThueTho.WpanelDanhS.Children.Clear();
            List<Tho>  DStho = dAOTho.FilterTho(filterTho, user.Id);
            foreach (Tho tho in DStho)
            {
                tho.CheckDcYeuThich(user.DSYeuThich); 
                userControl = new UCDanhSachTho(tho,uCThueTho.user);
                userControl.Width = 280;
                userControl.Height = 400;
                userControl.Margin = new Thickness(10);
                // Thêm UserControl vào WrapPanel
                uCThueTho.WpanelDanhS.Children.Add(userControl);
            }
        }


    }   
}
