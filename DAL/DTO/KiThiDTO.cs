using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class KiThiDTO
    {


        public KiThiDTO()
        {
           
        }

        public KiThiDTO(int iD, string maKiThi, string tenKiThi, string admin, DateTime thoiGianBD, DateTime thoiGianKT)
        {
            ID = iD;
            MaKiThi = maKiThi;
            TenKiThi = tenKiThi;
            Admin = admin;
            ThoiGianBD = thoiGianBD;
            ThoiGianKT = thoiGianKT;
        }

        public int ID { get; set; }

        public string  MaKiThi { get; set; }
        public string TenKiThi { get; set; }
        public string Admin { get; set; }

        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }

    }
}
