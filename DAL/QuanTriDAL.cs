using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class QuanTriDAL
    {
        private readonly DuLieuDAL quanTri;
        public QuanTriDAL()
        {
            quanTri = new DuLieuDAL();
        }
        public List<QUANTRI> GetThongTinQuanTri()
        {
            return quanTri.QUANTRI.ToList();
        }
    }
}

