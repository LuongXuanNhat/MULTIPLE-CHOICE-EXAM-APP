using OfficeOpenXml.ConditionalFormatting;
using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL
{
    internal class GiangVienDAL
    {
        private readonly DuLieuDAL duLieuDAL;
        public GiangVienDAL()
        {
            duLieuDAL = new DuLieuDAL();    
        }

        public List<GIANGVIEN> GetGIANGVIENs()
        {
            return duLieuDAL.GIANGVIEN.ToList();
        }

        public List<GIANGVIEN> FindName(string tengv)
        {
            return duLieuDAL.GIANGVIEN.Where(p => p.TENGV.Contains(tengv.Trim())).ToList();
        }

        public static void InsertUpdate(GiangVienDTO gIANGVIEN)
        {
            GIANGVIEN giangv = new GIANGVIEN(); 
            giangv.STT = gIANGVIEN.STT;
            giangv.MAGV = gIANGVIEN.MAGV;
            giangv.TENGV = gIANGVIEN.TENGV;
            giangv.NGAYSINH = gIANGVIEN.NGAYSINH;
            giangv.MATKHAU = gIANGVIEN.MATKHAU;
            giangv.InsertUpdate();
        }

        public void CapNhapGiangVien(string magv,string Hoten,DateTime date, string matkhau)
        {
            GIANGVIEN gIANGVIEN = duLieuDAL.GIANGVIEN.Find(magv);
            gIANGVIEN.MAGV = magv;
            gIANGVIEN.TENGV = Hoten;
            gIANGVIEN.NGAYSINH = date;
            gIANGVIEN.MATKHAU = matkhau;
            duLieuDAL.SaveChanges();

        }

        public void DoiMatKhau(string magv,string matkhau)
        {
            GIANGVIEN gIANGVIEN = duLieuDAL.GIANGVIEN.Find(magv);
            gIANGVIEN.MATKHAU = matkhau;
            duLieuDAL.SaveChanges();
        }


        public static GiangVienDTO GETGiangVien(string magv)
        {
            GIANGVIEN giangvien = GIANGVIEN.GETGiangVien(magv);
            GiangVienDTO giangVienDTO = new GiangVienDTO();
            giangVienDTO.STT = giangvien.STT.Value;
            giangVienDTO.MAGV = giangvien.MAGV;
            giangVienDTO.TENGV = giangvien.TENGV;
            giangVienDTO.NGAYSINH = giangvien.NGAYSINH;
            giangVienDTO.MATKHAU = giangvien.MATKHAU;
            return giangVienDTO;
        }
      

         

       
    }
}
