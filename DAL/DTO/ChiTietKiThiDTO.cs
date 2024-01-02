using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class ChiTietKiThiDTO
    {

        public ChiTietKiThiDTO()
        {
            
        }

        public ChiTietKiThiDTO(string maKiThi, string maMonThi, string maSinhVien, double diem, DateTime thoiGianBD, DateTime thoiGianKT, int thoiGianThi)
        {
            MaKiThi = maKiThi;
            MaMonThi = maMonThi;
            MaSinhVien = maSinhVien;
            Diem = diem;
            ThoiGianBD = thoiGianBD;
            ThoiGianKT = thoiGianKT;
            ThoiGianThi = thoiGianThi;
        }

        public string MaKiThi { get; set; }
        public string MaMonThi { get; set; }
        public string MaSinhVien { get; set; }
        public double Diem { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }
        public int ThoiGianThi { get; set; }
    }
}
