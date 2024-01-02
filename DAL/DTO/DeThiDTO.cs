using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.DAL.DTO
{
    internal class DeThiDTO
    {


        public DeThiDTO()
        {
           
        }

        public DeThiDTO(int iD, string maDeThi, string maKiThi, string maMonThi)
        {
            ID = iD;
            MaDeThi = maDeThi;
            MaKiThi = maKiThi;
            MaMonThi = maMonThi;
        }

        public int ID { get; set; }
        public string MaDeThi { get; set; }
        public string MaKiThi { get; set; }
        public string MaMonThi { get; set; }

    }
}
