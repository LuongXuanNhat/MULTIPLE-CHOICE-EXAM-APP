using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.UI.Admin.DanhSachSinhVien
{
    public partial class ThemMotSinhVien : Form
    {
        frmAdmin frmAdmin = new frmAdmin();
        public ThemMotSinhVien(frmAdmin frm)
        {
            InitializeComponent();
            this.frmAdmin = frm;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVienDTO sinhVienDTO = new SinhVienDTO();

                sinhVienDTO.STT++;
                sinhVienDTO.MaSV = txtMaSinhVien.Text;
                sinhVienDTO.Lop = txtLop.Text;
                sinhVienDTO.TenSV = txtTenSinhVien.Text;
                sinhVienDTO.NgaySinh = dtNgaySinhSinhVien.Value;
                sinhVienDTO.MatKhau = txtMatKhau.Text;
                SinhVienBAL.InsertUpdate(sinhVienDTO);
                frmAdmin.frmAdmin_Load(sender, e);
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
