using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class Tho:User
    {
        private string kinhnghiem;
        private string linhVuc;
        private string chuyenMon;
        private int giaTien;
        private float danhGia;
        private bool dcYeuThich=false;

        public Tho(int id, string hoTen, string cCCD, string sDT, DateTime dob, string khuvuc,string linhvuc,string chuyenmon, string kinhnghiem, int giaTien,float danhgia) : base(id, hoTen, cCCD, sDT, dob, khuvuc)
        {
            this.linhVuc = linhvuc;
            this.chuyenMon = chuyenmon;
            this.giaTien = giaTien;
            this.danhGia = danhgia;
            this.Kinhnghiem= kinhnghiem;
        }

        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }

        public float DanhGia { get => danhGia; set => danhGia = value; }
        public string Kinhnghiem { get => kinhnghiem; set => kinhnghiem = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public bool DcYeuThich { get => dcYeuThich; set => dcYeuThich = value; }

        public void CheckDcYeuThich(List <int> Ds)
        {
            DcYeuThich = Ds.Contains(Id);
        }    

    }
}
