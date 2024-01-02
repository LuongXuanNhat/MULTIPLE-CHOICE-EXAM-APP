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
    class MonThiDAL
    {
        private readonly DuLieuDAL monThi;
        public MonThiDAL()
        {
            monThi = new DuLieuDAL();
        }
        public List<MONTHI> GetThongTinMonThi()
        {
            return monThi.MONTHI.ToList();
        }

        public static void InsertUpdate(MonThiDTO monThiDTO)
        {

            
            MONTHI monthi = new MONTHI();
            monthi.STT = monThiDTO.STT;
            monthi.MAMT = monThiDTO.MaMT;
            monthi.TENMT = monThiDTO.TenMT;
            monthi.InsertUpdate();
        }
    }
}

