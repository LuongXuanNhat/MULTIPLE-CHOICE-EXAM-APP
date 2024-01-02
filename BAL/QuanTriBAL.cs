using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThiTracNghiem.BAL
{
    internal class QuanTriBAL
    {
        private readonly QuanTriDAL quanTriDAL;
        public QuanTriBAL()
        {
            quanTriDAL = new QuanTriDAL();
        }

        public List<QUANTRI> GetQuanTri()
        {
            return quanTriDAL.GetThongTinQuanTri();  
        }

        
    }
}
