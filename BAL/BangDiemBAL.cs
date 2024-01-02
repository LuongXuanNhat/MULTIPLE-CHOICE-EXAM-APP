using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemThiTracNghiem.DAL;
using PhanMemThiTracNghiem.DAL.Model;

namespace PhanMemThiTracNghiem.DAL
{
    class BangDiemBAL
    {
        private readonly BangDiemDAL bangDiemDAL;
        public BangDiemBAL()
        {
            bangDiemDAL = new BangDiemDAL();
        }
        public List<BANGDIEM> GetThongTinDiem()
        {
            return bangDiemDAL.GetThongTinDiem();
        }
        public bool LuuDiemThi(BANGDIEM LuuDiemThi)
        {
            try
            {               
                return bangDiemDAL.LuuDiemThi(LuuDiemThi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public bool LuuDiemThi(int ID, float DIEM, string MASV, string MAKT, string MAMT)
        //{
        //    try
        //    {
        //        return bangDiemDAL.LuuDiemThi(ID, DIEM,  MASV, MAKT, MAMT);
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
            
        //}
    }
}

