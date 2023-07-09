using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class KyThiBAL
    {
        private readonly KyThiDAL kyThiDAL;
        public KyThiBAL()
        {
            kyThiDAL = new KyThiDAL();
        }
        public List<KITHI> GetThongTinKyThi()
        {
            return kyThiDAL.GetThongTinKyThi();
        }
    }
}

