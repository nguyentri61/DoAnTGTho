using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class DanhGia
    {
        private int iDCongViec;
        private float danhGiaCV;
        private string moTaDanhGia="";
        private string tieuDeCViec= "Cần thuê thợ điện tử chuyên nghiệp cho dự án mới";
        private List<string> imageDG;

        public DanhGia(int iDCongViec, float danhGiaCV, string moTaDanhGia)
        {
            this.iDCongViec = iDCongViec;
            this.danhGiaCV = danhGiaCV;
            this.moTaDanhGia = moTaDanhGia;
        }
        public DanhGia() { }
        public int IDCongViec { get => iDCongViec; set => iDCongViec = value; }
        public float DanhGiaCV { get => danhGiaCV; set => danhGiaCV = value; }
        public string MoTaDanhGia { get => moTaDanhGia; set => moTaDanhGia = value; }
        public List<string> ImageDG { get => imageDG; set => imageDG = value; }
        public string TieuDeCViec { get => tieuDeCViec; set => tieuDeCViec = value; }
    }
}
