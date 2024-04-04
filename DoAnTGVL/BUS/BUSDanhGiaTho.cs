using DoAnTGVL.Class;
using DoAnTGVL.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnTGVL.BUS
{
    public class BUSDanhGiaTho
    {
        string solutionFilePath = FindSolutionFile();
        private string image = "";
        DAODanhGia dAODanhGia = new DAODanhGia();   

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
                System.IO.File.Copy(source, destination);
            }
            else
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fileName);
                string fileExtension = System.IO.Path.GetExtension(fileName);
                string newFileName = fileNameWithoutExtension + "_" + Guid.NewGuid().ToString().Substring(0, 8) + fileExtension;
                Image += newFileName + " ";
                
                destination = System.IO.Path.Combine(folder_path, destinationFolder, newFileName);
                System.IO.File.Copy(source, destination);
            }
        }
        static string FindSolutionFile()
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

        public void AddData(DanhGia danhGia)
        {
            if (danhGia.MoTaDanhGia != "" && danhGia.DanhGiaCV != 0)
                dAODanhGia.Add(danhGia, Image);
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }
    }
}
