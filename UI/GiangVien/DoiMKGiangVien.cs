using PhanMemThiTracNghiem.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.UI.GiangVien
{
    public partial class DoiMKGiangVien : Form
    {
        private readonly GiangVienBAL giangVienBAL;
        frmGiangVien frmgv;
        string magv1;
        public DoiMKGiangVien(string magv)
        {
            this.magv1 = magv;
            InitializeComponent();
            giangVienBAL = new GiangVienBAL();  
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string magv = magv1.ToString();
            string matkhau = "";
            if (txtMatkhauCu.Text != GiangVienBAL.GETGiangVien(magv).MATKHAU)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
            else if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
            }
            else
            {
                matkhau = txtMatKhauMoi.Text;
                giangVienBAL.DoiMatKhau(magv,matkhau);
                MessageBox.Show("Đổi thành công");
                this.Close();   
            }
        }
    }
}
