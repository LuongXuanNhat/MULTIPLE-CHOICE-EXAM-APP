using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class SinhVienDTO
    {

        public SinhVienDTO()
        {
           
        }
        public SinhVienDTO(int sTT, string maSV, string lop, string tenSV, DateTime ngaySinh, string matKhau)
        {
            STT = sTT;
            MaSV = maSV;
            Lop = lop;
            TenSV = tenSV;
            NgaySinh = ngaySinh;
            MatKhau = matKhau;
        }

        public int  STT { get; set; }
        public string MaSV  { get; set; }
        public string Lop { get; set; }

        public string TenSV { get; set; }

        public DateTime  NgaySinh { get; set; }
        public string MatKhau { get; set; }

    }
}
