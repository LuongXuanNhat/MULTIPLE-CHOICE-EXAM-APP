using ExcelDataReader;
using PhanMemThiTracNghiem.BAL;
using PhanMemThiTracNghiem.DAL.DTO;
using PhanMemThiTracNghiem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.UI.Admin.DanhSachSinhVien
{
    public partial class NhapExcelSinhVien : Form
    {
        private readonly DuLieuDAL duLieuDAL;
        private readonly SinhVienBAL sinhVienBAL;
        frmAdmin frmadmin = new frmAdmin();
        
        public NhapExcelSinhVien(frmAdmin frm)
        {
            InitializeComponent();
            duLieuDAL = new DuLieuDAL();
            sinhVienBAL = new SinhVienBAL();
            this.frmadmin = frm;
        }

        DataTableCollection tableCollection;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook| *.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName); //add sheet to combobox
                        }
                    }
                }
            }
        }

        public void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
           
            if (dt != null)
            {
                List<SinhVienDTO> listsinhVienDTOs = new List<SinhVienDTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SinhVienDTO sinhVienDTO = new SinhVienDTO();
                    sinhVienDTO.STT =int.Parse(dt.Rows[i]["STT"].ToString());
                    sinhVienDTO.MaSV = dt.Rows[i]["MASV"].ToString();
                    sinhVienDTO.Lop = dt.Rows[i]["LOP"].ToString();
                    sinhVienDTO.TenSV = dt.Rows[i]["TENSV"].ToString();
                    sinhVienDTO.NgaySinh =DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString());
                    sinhVienDTO.MatKhau = dt.Rows[i]["MATKHAU"].ToString();
                    listsinhVienDTOs.Add(sinhVienDTO);  
                }
                dgvThemExcelSinhVien.DataSource = listsinhVienDTOs;
            }
           

        }

        private void btnLuuDL_Click(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            var database = new DuLieuDAL();
            List<SINHVIEN> list = new List<SINHVIEN>();

            try
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SINHVIEN sinhvien = new SINHVIEN()
                    {
                        STT = int.Parse(dt.Rows[i]["STT"].ToString()),
                        MASV = dt.Rows[i]["MASV"].ToString(),
                        LOP = dt.Rows[i]["LOP"].ToString(),
                        TENSV = dt.Rows[i]["TENSV"].ToString(),
                        NGAYSINH = DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString()),
                        MATKHAU = dt.Rows[i]["MATKHAU"].ToString()
                    };
                    list.Add(sinhvien);
                }
                foreach (var sinhvien in list)
                {
                    duLieuDAL.SINHVIEN.AddOrUpdate(sinhvien);
                    duLieuDAL.SaveChanges();
                    frmadmin.frmAdmin_Load(sender, e);
                }
                MessageBox.Show("Lưu thành công!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
