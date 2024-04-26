using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using DoAnTGVL.UControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DoAnTGVL.BUS
{
    public class BUSChiTietCongViec
    {
        private string image = "";

        DAODanhGia dAODanhGia = new DAODanhGia();

        public string Image { get => image; set => image = value; }
        DAODSCongViec dAODSCongViec = new DAODSCongViec();
        DAOBaiDang dAOBaiDang = new DAOBaiDang();
        public void Them(BaiDang baiDang, Tho tho)
        {
            if (dAODSCongViec.CheckNgayBan(baiDang.DateThue, tho.Id))
            {
                dAODSCongViec.ThoThem(baiDang, tho);
            }
            else
            {
                new ShowDialogCustom("Bạn đã có công việc khác vào ngày này!", ShowDialogCustom.OK).Show();
            }
        }

        public void Xoa(CongViec cv)
        {
            dAODSCongViec.XoaDSCongViec(cv.ID);
        }

        public void Sua(CongViec cv, Tho tho)
        {
            dAODSCongViec.SuaDSCongViec(cv, tho);
        }

        public List<CongViec> LoadData(int id)
        {
            return dAODSCongViec.ReadAllCongViec(id);
        }

        public List<CongViec> LoadDataHT(int id)
        {
            return dAODSCongViec.ReadAllLichSuCongViec(id, "Đã hoàn thành");
        }

        public List<CongViec> LoadDSThueTho(int id, string trangthai)
        {
            return dAODSCongViec.ReadAllDSThueTho(id, trangthai);
        }

        public List<CongViec> FilterCV(FilterDSCongViec filterDSCongViec, int idtho)
        {
            return dAODSCongViec.FilterCongViec(filterDSCongViec, idtho);
        }

        public List<CongViec> FilterCVHT(FilterDSCongViec filterDSCongViec, int idtho)
        {
            return dAODSCongViec.FilterCongViecDaHoanThanh(filterDSCongViec, idtho);
        }

        public void AddImage(string source)
        {
            string fileName = System.IO.Path.GetFileName(source);
            string destinationFolder = "ImageCongViec";
            string path = System.IO.Path.GetFullPath(destinationFolder);
            string folder_path = path.Substring(0, path.IndexOf("bin"));
            string destination = System.IO.Path.Combine(folder_path, destinationFolder, fileName);
            if (!System.IO.File.Exists(destination))
            {
                System.IO.File.Copy(source, destination);
                Image += fileName + "  ";
            }
            else
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fileName);
                string fileExtension = System.IO.Path.GetExtension(fileName);
                string newFileName = fileNameWithoutExtension + "_" + Guid.NewGuid().ToString().Substring(0, 8) + fileExtension;
                Image += newFileName + "  ";
                destination = System.IO.Path.Combine(folder_path, destinationFolder, newFileName);
                System.IO.File.Copy(source, destination);
            }

        }
        public string FindSolutionFile()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

            while (directoryInfo != null)
            {
                FileInfo[] files = directoryInfo.GetFiles("*.sln");
                if (files.Length > 0)
                {
                    return directoryInfo.FullName;
                }
                directoryInfo = directoryInfo.Parent;
            }

            return null;
        }

        public void Add(CongViec congviec)
        {
            if (congviec.ChiTietSua != "" && congviec.ChiPhi != null)
                dAODSCongViec.Add(congviec, Image);
            else
                new ShowDialogCustom("Vui lòng nhập đầy đủ thông tin", ShowDialogCustom.OK).Show();
        }

        public void CreateWrapPhanHoi(Tho tho, User user, ChiTietLichSuThueTho ctlstt)
        {
            UserControl userControl = new UserControl();
            List<DanhGia> DSDanhGia = dAODanhGia.ReadDanhGia(tho);
            foreach (DanhGia dg in DSDanhGia)
            {
                userControl = new UCDanhGia(dg);
                userControl.Height = 300;
                userControl.Width = 1000;
                ctlstt.WpanelPhanHoi.Children.Add(userControl);
            }
        }
    }
}
