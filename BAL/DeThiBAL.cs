using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class DeThiBAL
    {
        private readonly DeThiDAL deThiDAL;
        public DeThiBAL()
        {
            deThiDAL = new DeThiDAL();
        }
        public List<DETHI> GetThongTinDeThi()
        {
            return deThiDAL.GetThongTinDeThi();
        }

        public static void InsertUpdate(DeThiDTO deThiDTO)
        {
            DeThiDAL.InsertUpdate(deThiDTO);
        }
    }
}

