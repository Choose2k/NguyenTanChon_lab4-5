using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NguyenTanChon_lab4_5.Models;

namespace NguyenTanChon_lab4_5.Models
{
    public class Giohang
    {
        MydataDataContext data = new MydataDataContext();
        public int masach { get; set; }

        [Display(Name = "Ten Sach")]
        public string tensach { get; set; }

        [Display(Name = "Ảnh Bìa")]
        public string hinh { get; set; }
        [Display(Name = "Gía Bán")]
        public Double giaban { get; set; }

        [Display(Name = "Số Lượng")]
        public int iSoluong { get; set; }

        [Display(Name = "Thành Tiền")]
        public Double dThanhtien
        {
            get { return iSoluong * giaban; }
        }
        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
    }
}