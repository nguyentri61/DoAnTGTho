using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTGVL.Class
{
    public class BaiDang : INotifyPropertyChanged
    {
        private int iD;
        private string iDUser;
        private string tenUser;
        private string tieuDe;
        private string linhVuc;
        private string khuVuc;
        private string moTa;
        private DateTime date =DateTime.Today;
        private string kinhNghiem;
        private string ghiChu;
        private string yeuCau;
        public BaiDang() { }
        public BaiDang(int iD, string iDUser, string tieuDe, string linhVuc, string khuVuc, string moTa, DateTime date, string kinhNghiem, string yeuCau ,string ghiChu)
        {
            this.ID = iD;
            this.IDUser = iDUser;
            this.TieuDe = tieuDe; 
            this.LinhVuc = linhVuc;
            this.KhuVuc = khuVuc;
            this.MoTa = moTa;
            this.DateThue = date.Date;
            this.KinhNghiem = kinhNghiem;
            this.GhiChu = ghiChu;
            this.YeuCau = yeuCau;
        }

        public int ID { get => iD; set => iD = value; }
        public string IDUser { get => iDUser; set => iDUser = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public DateTime DateThue { get => date; set => date = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string TenUser { get => tenUser; set => tenUser = value; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            } 
                
        }    
    }
}
