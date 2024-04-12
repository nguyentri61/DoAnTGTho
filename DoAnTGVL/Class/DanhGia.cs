using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class DanhGia
    {
        private int iDCongViec;
        private string tenUser;
        private DateTime ngayThue;
        private int giaThue;
        private int danhGiaCV =1;
        private string moTaDanhGia="";
        private string tieuDeCViec= "Cần thuê thợ điện tử chuyên nghiệp cho dự án mới";
        private List<string> imageDG= new List<string>();
        private string linhVuc;
        private int giaTien;

        public DanhGia(int iDCongViec, int danhGiaCV, string moTaDanhGia)
        {
            this.iDCongViec = iDCongViec;
            this.danhGiaCV = danhGiaCV;
            this.moTaDanhGia = moTaDanhGia;
        }
        public DanhGia() { }
        public int IDCongViec { get => iDCongViec; set => iDCongViec = value; }
        public int DanhGiaCV { get => danhGiaCV; set => danhGiaCV = value; }
        public string MoTaDanhGia { get => moTaDanhGia; set => moTaDanhGia = value; }
        public List<string> ImageDG { get => imageDG; set => imageDG = value; }
        public string TieuDeCViec { get => tieuDeCViec; set => tieuDeCViec = value; }
        public string TenUser { get => tenUser; set => tenUser = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public int GiaThue { get => giaThue; set => giaThue = value; }
        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }

        public void GetSource(string input)
        {
            
            string[] words = input.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                ImageDG.Add(word);
            }
        }
    }
}
