using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
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
    }
}

