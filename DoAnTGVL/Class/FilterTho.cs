using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class FilterTho : Filter
    {
        private float danhGia = 0;
        private string chuyenMon = "";
        private bool yeuThich=false;
        public float DanhGia { get => danhGia; set => danhGia = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
        public bool YeuThich { get => yeuThich; set => yeuThich = value; }

        public override bool checkemp()
        {
            if ( base.checkemp() && danhGia == 0 && chuyenMon == "" && yeuThich==false)
                return true;
            return false;
        }
        public override void reset()
        {
            base.reset();
            yeuThich = false;
            danhGia = 0;
            chuyenMon = "";
        }        
    }
}
