using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class DeThiDAL
    {
        private readonly DuLieuDAL deThi;
        public DeThiDAL()
        {
            deThi = new DuLieuDAL();
        }
        public List<DETHI> GetThongTinDeThi()
        {
            return deThi.DETHI.ToList();
        }
    }
}

