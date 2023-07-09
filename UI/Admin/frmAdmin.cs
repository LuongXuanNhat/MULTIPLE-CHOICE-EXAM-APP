using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using PhanMemThiTracNghiem.UI.Admin.DanhSachGiangVien;
using PhanMemThiTracNghiem.UI.Admin.DanhSachSinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.UI.Admin
{
    public partial class frmAdmin: Form
    {
        private readonly GiangVienBAL giangVienBAL;
        private readonly SinhVienBAL sinhVienBAL;
        private readonly QuanTriBAL quanTriBAL;
        private readonly QUANTRI quanTri;
        
        public frmAdmin(QUANTRI qt)
        {
            InitializeComponent();
            giangVienBAL = new GiangVienBAL();
            sinhVienBAL = new SinhVienBAL();
            quanTriBAL = new QuanTriBAL();
            quanTri = qt;
        }

        public frmAdmin()
        {
        }

        private void btnNhapExcelGiangVien_Click(object sender, EventArgs e)
        {
            NhapExcelGiangVien nhapExcelGiangVien = new NhapExcelGiangVien();
            nhapExcelGiangVien.ShowDialog();
        }

        public void frmAdmin_Load(object sender, EventArgs e)
        {
            dgvDanhSachGiangVien.DataSource = giangVienBAL.GetGIANGVIENs();
            dgvDanhSachSinhVien.DataSource = sinhVienBAL.GetSINHVIENs();
        }

        private void dgvDanhSachGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachGiangVien.CurrentRow.Selected = true;
            txtMaGiangVien.Text = dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["MAGV"].FormattedValue.ToString();
            txtTenGiangVien.Text = dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["TENGV"].FormattedValue.ToString();
            dtNgaySinhGiangVien.Value = DateTime.Parse(dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString());
            txtMatKhauGiangVien.Text = dgvDanhSachGiangVien.Rows[e.RowIndex].Cells["MATKHAU"].FormattedValue.ToString();
        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachSinhVien.CurrentRow.Selected = true;
            txtMaSinhVien.Text = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["MASV"].FormattedValue.ToString();
            txtLopSinhVien.Text = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["LOP"].FormattedValue.ToString();
            txtTenSinhVien.Text = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["TENSV"].FormattedValue.ToString();
            dtNgaySinhSinhVien.Value = DateTime.Parse(dgvDanhSachSinhVien.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString());
        }

        private void btnCapNhapGiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMaGiangVien.Text;
                string tengv = txtTenGiangVien.Text;
                DateTime ngaysinh = dtNgaySinhGiangVien.Value;
                string matkhau = txtMatKhauGiangVien.Text;
                giangVienBAL.CapNhapGiangVien(magv,tengv,ngaysinh,matkhau);
                
                MessageBox.Show("Cập nhập thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnNhapMotGiangVien_Click(object sender, EventArgs e)
        {
            ThemMotGiangVien themMot = new ThemMotGiangVien(this);
            themMot.ShowDialog();
        }

        private void btnXoaMotGiangVien_Click(object sender, EventArgs e)
        {
            dgvDanhSachGiangVien.CurrentRow.Selected = true;
            string r = dgvDanhSachGiangVien.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                GiangVienBAL.Delete(r);
                MessageBox.Show("Xóa thành công !!!");
                dgvDanhSachGiangVien.DataSource = giangVienBAL.GetGIANGVIENs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemGiangVien_TextChanged(object sender, EventArgs e)
        {
            string tengv = txtTimKiemGiangVien.Text.Trim();
            if (tengv == "")
            {
                frmAdmin_Load(sender, e);
            }
            else
            {
                dgvDanhSachGiangVien.DataSource  = giangVienBAL.FindName(tengv);
            }
        }

        private void btnNhapExcelSinhVien_Click(object sender, EventArgs e)
        {
            NhapExcelSinhVien nhapExcelSinhVien = new NhapExcelSinhVien(this);
            nhapExcelSinhVien.ShowDialog();
        }

        private void btnThemMotSinhVien_Click(object sender, EventArgs e)
        {
            ThemMotSinhVien themMotSinhVien = new ThemMotSinhVien(this);
            themMotSinhVien.ShowDialog();
        }

        private void btnXoaMotSinhVien_Click(object sender, EventArgs e)
        {
            dgvDanhSachSinhVien.CurrentRow.Selected = true;
            string r = dgvDanhSachSinhVien.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                SinhVienBAL.Delete(r);
                MessageBox.Show("Xóa thành công !!!");
                dgvDanhSachSinhVien.DataSource = sinhVienBAL.GetSINHVIENs();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhapSV_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txtMaSinhVien.Text;
                string lop = txtLopSinhVien.Text;
                string tensv = txtTenSinhVien.Text;
                DateTime ngaysinh = dtNgaySinhSinhVien.Value;
                sinhVienBAL.CapNhapSinhVien(masv,lop, tensv, ngaysinh);
                MessageBox.Show("Cập nhập thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemSinhVien_TextChanged(object sender, EventArgs e)
        {
            string tensv = txtTimKiemSinhVien.Text.Trim();
            if (tensv == "")
            {
                frmAdmin_Load(sender, e);
            }
            else
            {
                dgvDanhSachSinhVien.DataSource = sinhVienBAL.FindName(tensv);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
