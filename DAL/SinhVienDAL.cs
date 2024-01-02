using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL
{
    internal class SinhVienDAL
    {

        private readonly DuLieuDAL duLieuDAL;
        public SinhVienDAL()
        {
            duLieuDAL = new DuLieuDAL();
        }

        public List<SINHVIEN> GetSINHVIENs()
        {
            return duLieuDAL.SINHVIEN.ToList();    
        }

        public List<SINHVIEN> FindName(string tensv)
        {
            return duLieuDAL.SINHVIEN.Where(x => x.TENSV.Contains(tensv.Trim())).ToList();
        }

        public static void InsertUpdate(SinhVienDTO sinhVienDTO)
        {
            SINHVIEN sinhvien = new SINHVIEN();
            sinhvien.STT = sinhVienDTO.STT;
            sinhvien.MASV = sinhVienDTO.MaSV;
            sinhvien.LOP = sinhVienDTO.Lop;
            sinhvien.TENSV = sinhVienDTO.TenSV;
            sinhvien.NGAYSINH = sinhVienDTO.NgaySinh;
            sinhvien.MATKHAU = sinhVienDTO.MatKhau;
            sinhvien.InsertUpdate();
        }


        public  void CapNhapSinhVien(string masv, string lop, string tensv,DateTime date)
        {
            SINHVIEN sinhvien = duLieuDAL.SINHVIEN.Find(masv);
            sinhvien.MASV = masv;
            sinhvien.LOP = lop;
            sinhvien.TENSV = tensv;
            sinhvien.NGAYSINH = date;
            duLieuDAL.SaveChanges();
        }
    }
}
