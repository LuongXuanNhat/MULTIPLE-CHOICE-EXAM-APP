using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class ChiTietDeThiDTO
    {
        public ChiTietDeThiDTO()
        {
           
        }


        public ChiTietDeThiDTO(string maDeThi, int maCauHoi, string capDo)
        {
            MaDeThi = maDeThi;
            MaCauHoi = maCauHoi;
            CapDo = capDo;
        }

        public string MaDeThi { get; set; }
        public int MaCauHoi { get; set; }

        public string CapDo { get; set; }   

    }
}
