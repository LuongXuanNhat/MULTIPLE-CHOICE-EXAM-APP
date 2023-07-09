using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class ChiTietKyThiDAL
    {
        private readonly DuLieuDAL chiTietKyThi;
        public ChiTietKyThiDAL()
        {
            chiTietKyThi = new DuLieuDAL();
        }
        public List<CHITIETKYTHI> GetThongTinChiTietKyThi()
        {
            return chiTietKyThi.CHITIETKYTHI.ToList();
        }
        public void LuuChiTietKyThi(SINHVIEN sv, String MAKT, MONTHI monThi, float diem, DateTime thoiGianBD, DateTime thoiGianKT, int thoiGianThi)
        {
            foreach (var item in GetThongTinChiTietKyThi())
            {
                if(item.MAKITHI == MAKT && item.MASV == sv.MASV && item.MAMT == item.MAMT)
                {
                    item.DIEM = diem;
                    item.THOIGIANBD = thoiGianBD;
                    item.THOIGIANKT = thoiGianKT;
                    item.THOIGIANTHI = thoiGianThi;
                    chiTietKyThi.SaveChanges();
                    break;
                }
            }
        }
    }
}

