using PhanMemThiTracNghiem.UI.Admin;
using PhanMemThiTracNghiem.UI.GiangVien;
using PhanMemThiTracNghiem.UI.SinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
