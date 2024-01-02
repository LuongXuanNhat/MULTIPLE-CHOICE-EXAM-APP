using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class ChiTietKyThiBAL
    {
        private readonly ChiTietKyThiDAL chiTietKyThiDAL;
        public ChiTietKyThiBAL()
        {
            chiTietKyThiDAL = new ChiTietKyThiDAL();
        }
        public List<CHITIETKYTHI> GetThongTinChiTietKyThi()
        {
            return chiTietKyThiDAL.GetThongTinChiTietKyThi();
        }

        public static void InsertUpdate(ChiTietKiThiDTO chiTietKiThiDTO)
        {
            ChiTietKyThiDAL.InsertUpdate(chiTietKiThiDTO);  
        }
        public void LuuChiTietKyThi(SINHVIEN sv, String MAKT, MONTHI monThi, float diem, DateTime thoiGianBD, DateTime thoiGianKT, int thoiGianThi)
        {
            chiTietKyThiDAL.LuuChiTietKyThi(sv, MAKT, monThi, diem, thoiGianBD, thoiGianKT, thoiGianThi);
        }
    }
}

