using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class Tho:Person
    {
        private string kinhNghiem;
        private string linhVuc;
        private string chuyenMon;
        private int giaTien;
        private float danhGia;
        private bool dcYeuThich=false;

        public Tho(int id, string hoTen, string cCCD, string sDT, DateTime dob, string khuvuc,string linhVuc,string chuyenmon, string kinhNghiem, int giaTien,float danhgia) : base(id, hoTen, cCCD, sDT, dob, khuvuc)
        {
            this.LinhVuc = linhVuc;
            this.chuyenMon = chuyenmon;
            this.giaTien = giaTien;
            this.danhGia = danhgia;
            this.kinhNghiem = kinhNghiem;
        }
        
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public bool DcYeuThich { get => dcYeuThich; set => dcYeuThich = value; }
        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }

        public void CheckDcYeuThich(List <int> Ds)
        {
            DcYeuThich = Ds.Contains(Id);
        }    

    }
}
