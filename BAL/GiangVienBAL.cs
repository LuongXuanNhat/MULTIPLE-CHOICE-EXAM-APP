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
    internal class GiangVienBAL
    {
        private readonly GiangVienDAL giangVienDAL;
        public GiangVienBAL()
        {
            this.giangVienDAL = new GiangVienDAL();     
        }

        public List<GIANGVIEN> GetGIANGVIENs()
        {
            return giangVienDAL.GetGIANGVIENs();
        }

        public static void InsertUpdate(GiangVienDTO a)
        {
            GiangVienDAL.InsertUpdate(a);
        }

        public static void Delete(string magv)
        {
            GIANGVIEN.Delete(magv); 
        }

        public List<GIANGVIEN> FindName(string magv)
        {
            return giangVienDAL.FindName(magv); 
        }

        public void CapNhapGiangVien(string magv, string Hoten, DateTime date, string matkhau)
        {
            giangVienDAL.CapNhapGiangVien(magv, Hoten, date, matkhau);
        }

        public static GiangVienDTO GETGiangVien(string magv)
        {
            return GiangVienDAL.GETGiangVien(magv);
        }

        public void DoiMatKhau(string magv, string matkhau)
        {
            giangVienDAL.DoiMatKhau(magv, matkhau); 
        }
    }
}
