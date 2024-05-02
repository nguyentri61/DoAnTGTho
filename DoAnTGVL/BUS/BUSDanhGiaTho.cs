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
    public class BUSDanhGiaTho
    {
        
        private string image = "";
        
        DAODanhGia dAODanhGia = new DAODanhGia();   
        DAOTho dAOTho = new DAOTho();

        public string Image { get => image; set => image = value; }

        public void AddImage(string source)
        {
            string fileName = System.IO.Path.GetFileName(source);
            string destinationFolder = "ImageDanhGia";
            string path = System.IO.Path.GetFullPath(destinationFolder);
            string folder_path = path.Substring(0, path.IndexOf("bin"));
            string destination = System.IO.Path.Combine(folder_path, destinationFolder, fileName);
            if (!System.IO.File.Exists(destination))
            {
                Image += fileName + "  ";
                System.IO.File.Copy(source, destination);               
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

        public void AddData(DanhGia danhGia,int idCV)
        {
            if (danhGia.MoTaDanhGia != "" && danhGia.DanhGiaCV != 0)
            {
                dAODanhGia.Add(danhGia, idCV, Image);
                List<float> danhGiaTho = dAODanhGia.ReadSao(idCV);
                dAOTho.UpDateDG(danhGiaTho);
            }
            else
                new ShowDialogCustom("Vui lòng nhập đầy đủ thông tin!", ShowDialogCustom.OK).Show();
        }

        public void CreateWrapDanhGia(Tho tho, User user, ChiTietTho chiTietTho)
        {
            UserControl userControl=new UserControl();
            List<DanhGia> DSDanhGia = dAODanhGia.ReadDanhGia(tho);
            foreach (DanhGia dg in DSDanhGia)
            {
                userControl = new UCDanhGia(dg);
                userControl.Height = 300;
                userControl.Width = 900;
                //userControl.Margin = new Thickness(0, 5, 0, 0);

                chiTietTho.WpanelDanhGia.Children.Add(userControl);
            }
        }

        public void CreateWrapDanhGia(Tho tho,FilterDanhGia filterDanhGia, UCDSDanhGiaTho dsdgtho)
        {
            UserControl userControl = new UserControl();
            List<DanhGia> DSDanhGia = dAODanhGia.ReadDanhGia(tho, filterDanhGia);
            dsdgtho.WpanelDanhS.Children.Clear();
            foreach (DanhGia dg in DSDanhGia)
            {
                userControl = new UCDanhGia(dg);
                userControl.Height = 300;
                userControl.Width = 1000;
                userControl.Margin = new Thickness(0, 5, 0, 0);

                dsdgtho.WpanelDanhS.Children.Add(userControl);
            }
        }
    }
}
