using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PhanMemThiTracNghiem.UI.Admin;
using PhanMemThiTracNghiem.UI.GiangVien;
using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.UI.SinhVien;
using PhanMemThiTracNghiem.DAL;

namespace PhanMemThiTracNghiem
{
    public partial class frmLogin : Form
    {
        private readonly GiangVienBAL giangVienBAL;
        private readonly SinhVienBAL sinhVienBAL;
        private readonly QuanTriBAL quanTriBAL;
        public frmLogin()
        {
            InitializeComponent();

            sinhVienBAL = new SinhVienBAL();
            giangVienBAL = new GiangVienBAL();
            quanTriBAL = new QuanTriBAL();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                return;
            }
            else if (txtTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            // Nếu thông tin tài khoản nhập vào sai

            // ADMIN
            if (comboPhanQuyen.Text.Equals("Quản trị"))
            {
                foreach (var item in quanTriBAL.GetQuanTri())
                {
                    if (txtTaiKhoan.Text == item.ADMIN)
                    {
                        if (txtMatKhau.Text == item.MATKHAU)
                        {
                            frmAdmin frmAdmin = new frmAdmin(item);
                            this.Hide();
                            frmAdmin.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin mật khẩu không chính xác");
                            return;
                        }
                    }

                }
                MessageBox.Show("Thông tin tài khoản không chính xác");
                return;
            }
            // GIẢNG VIÊN
            else if (comboPhanQuyen.Text.Equals("Giảng viên"))
            {
                foreach (var item in giangVienBAL.GetGIANGVIENs())
                {
                    if (txtTaiKhoan.Text == item.MAGV)
                    {
                        if (txtMatKhau.Text == item.MATKHAU)
                        {
                            frmGiangVien frmGiangVien = new frmGiangVien(item.MAGV);
                            this.Hide();
                            frmGiangVien.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin mật khẩu không chính xác");
                            return;
                        }
                    }
                }
                MessageBox.Show("Thông tin tài khoản không chính xác");
                return;
            }
            // SINH VIÊN
            else
            {
                foreach (var item in sinhVienBAL.GetSINHVIENs())
                {
                    if (txtTaiKhoan.Text == item.MASV)
                    {
                        if (txtMatKhau.Text == item.MATKHAU)
                        {
                            frmSinhVien frmSinhVien = new frmSinhVien(item);
                            this.Hide();
                            frmSinhVien.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin mật khẩu không chính xác");
                            return;
                        }
                    }
                }
                MessageBox.Show("Thông tin tài khoản không chính xác");
                return;
            }





        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            comboPhanQuyen.Items.Add("Sinh viên");
            comboPhanQuyen.SelectedIndex = 0;
            comboPhanQuyen.Items.Add("Giảng viên");
            comboPhanQuyen.Items.Add("Quản trị");



        }

        

        private void chkHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = (chkHienMatKhau.Checked) ? '\0' : '*';
        }
    }
}
