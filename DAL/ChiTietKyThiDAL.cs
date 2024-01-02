using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
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

        public static void InsertUpdate(ChiTietKiThiDTO chiTietKiThiDTO)
        {
            CHITIETKYTHI cHITIETKYTHI = new CHITIETKYTHI();
            cHITIETKYTHI.MAKITHI = chiTietKiThiDTO.MaKiThi;
            cHITIETKYTHI.MAMT = chiTietKiThiDTO.MaMonThi;
            cHITIETKYTHI.DIEM = chiTietKiThiDTO.Diem;
            cHITIETKYTHI.THOIGIANBD = chiTietKiThiDTO.ThoiGianBD;
            cHITIETKYTHI.THOIGIANKT = chiTietKiThiDTO.ThoiGianKT;
            cHITIETKYTHI.THOIGIANTHI = chiTietKiThiDTO.ThoiGianThi;
            cHITIETKYTHI.MASV = chiTietKiThiDTO.MaSinhVien;
            cHITIETKYTHI.InsertUpdate();
        }
        public void LuuChiTietKyThi(SINHVIEN sv, String MAKT, MONTHI monThi, float diem, DateTime thoiGianBD, DateTime thoiGianKT, int thoiGianThi)
        {
            foreach (var item in GetThongTinChiTietKyThi())
            {
                if (item.MAKITHI == MAKT && item.MASV == sv.MASV && item.MAMT == item.MAMT)
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

