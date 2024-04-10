using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class FilterDanhGia
    {
        private float aveDanhGia;
        private string danhGia;
        private bool coAnh=true;

        public float AveDanhGia { get => aveDanhGia; set => aveDanhGia = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public bool CoAnh { get => coAnh; set => coAnh = value; }

        public string GetDanhGia()
        {
            if (danhGia.Contains("Sao"))
            {
                // Loại bỏ chữ "Sao" và các khoảng trắng
                return danhGia.Replace("Sao", "").Trim();
            }
            else 
            {
                // Trả về chuỗi trống nếu là "Tất cả"
                return "";
            }

        }
    }
}
