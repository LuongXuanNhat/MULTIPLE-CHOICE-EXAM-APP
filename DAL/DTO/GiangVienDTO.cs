using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class GiangVienDTO
    {


        public GiangVienDTO()
        {
           
        }
        public GiangVienDTO(int sTT, string mAGV, string tENGV, DateTime nGAYSINH, string mATKHAU)
        {
            STT = sTT;
            MAGV = mAGV;
            TENGV = tENGV;
            NGAYSINH = nGAYSINH;
            MATKHAU = mATKHAU;
        }

        public int STT { get; set; }
        public string MAGV { get; set; }
        public string TENGV { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string MATKHAU { get; set; }
    }
}
