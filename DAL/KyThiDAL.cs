using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class KyThiDAL
    {
        private readonly DuLieuDAL kyThi;
        public KyThiDAL()
        {
            kyThi = new DuLieuDAL();
        }
        public List<KITHI> GetThongTinKyThi()
        {
            return kyThi.KITHI.ToList();
        }
    }
}

