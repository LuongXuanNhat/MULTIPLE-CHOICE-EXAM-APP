using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class MonThiDTO
    {

        public MonThiDTO()
        {
           
        }
        public MonThiDTO(int sTT, string maMT, string tenMT)
        {
            STT = sTT;
            MaMT = maMT;
            TenMT = tenMT;
        }

        public int STT { get; set; }
        public string MaMT { get; set; }
        public string TenMT { get; set; }
    }
}
