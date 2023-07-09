using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.BAL
{
    internal class SinhVienBAL
    {
        private readonly SinhVienDAL sinhVienDAL;
        public SinhVienBAL()
        {
            sinhVienDAL = new SinhVienDAL();
        }
        
        public List<SINHVIEN> GetSINHVIENs()
        {
            return sinhVienDAL.GetSINHVIENs();  
        }

        public static void InsertUpdate(SinhVienDTO a)
        {
            SinhVienDAL.InsertUpdate(a);
        }

        public List<SINHVIEN> FindName(string tensv)
        {
            return sinhVienDAL.FindName(tensv);
        }

        public static void Delete(string masv)
        {
            SINHVIEN.Delete(masv);
        }

        public void CapNhapSinhVien(string masv, string lop, string tensv,DateTime date)
        {
            sinhVienDAL.CapNhapSinhVien(masv,lop,tensv,date);
        }
        
    }
}
