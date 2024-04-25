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
    internal class BUSThongBaoNhanTho
    {
        DAODSCongViec dAODSCongViec = new DAODSCongViec();
        DAOBaiDang dAOBaiDang = new DAOBaiDang();
        DAOTho dAOTho = new DAOTho();
        Tho tho;
        public void CreateWrapThongBao(User user, ThongBaoNhanTho thongBaoNhanTho)
        {
            UserControl userControl = new UserControl();
            thongBaoNhanTho.wrapTbao.Children.Clear();
            List<CongViec> congViecs = dAODSCongViec.ReadAllDSThueTho(user.Id, "Chờ được duyệt");
            foreach (CongViec congViec in congViecs)
            {
                tho=dAOTho.ReadDBToSLTho(congViec.IDTho);
                userControl = new UCTBaoNhanViec(user, congViec, tho);
                userControl.Height = 180;
                userControl.Width = 600;
                userControl.Margin = new Thickness(10);
                thongBaoNhanTho.wrapTbao.Children.Add(userControl);
            }
        }

        internal void XacNhan(CongViec congviec, Tho tho)
        {
            congviec.TrangThai = "Chưa thực hiện";
            dAODSCongViec.SuaDSCongViec(congviec, tho);
            dAODSCongViec.XoaTheoBaiDang(congviec);
            dAOBaiDang.XoaBaiDang(congviec.ID);
        }

        internal void Xoa(CongViec congviec, Tho tho)
        {
            dAODSCongViec.XoaDSCongViec(congviec.ID);
        }
    }
}
