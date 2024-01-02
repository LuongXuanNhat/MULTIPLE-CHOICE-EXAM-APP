using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemThiTracNghiem.DAL.Model;
using PhanMemThiTracNghiem.DAL;
using System.Collections.ObjectModel;
using PhanMemThiTracNghiem.BAL;

namespace PhanMemThiTracNghiem.UI.Admin.DanhSachGiangVien
{
    public partial class NhapExcelGiangVien : Form
    {
        DuLieuDAL duLieuDAL = new DuLieuDAL();
        List<GIANGVIEN> listGV = new List<GIANGVIEN>();
        frmAdmin frmAdmin = new frmAdmin();
        private readonly GiangVienBAL giangVienBAL;
        public NhapExcelGiangVien(frmAdmin _frmAdmin)
        {
            InitializeComponent();
            giangVienBAL = new GiangVienBAL();
            frmAdmin = _frmAdmin;
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

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GIANGVIEN giangvien = new GIANGVIEN();
                    giangvien.STT = Convert.ToInt32(dt.Rows[i]["STT"].ToString());
                    giangvien.MAGV = dt.Rows[i]["MAGV"].ToString();
                    giangvien.TENGV = dt.Rows[i]["TENGV"].ToString();
                    giangvien.NGAYSINH = DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString());
                    giangvien.MATKHAU = dt.Rows[i]["MATKHAU"].ToString();
                    listGV.Add(giangvien);
                }
            }
            dgvThemExcelSinhVien.DataSource = listGV;
        }

        private void btnLuuDL_Click(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            List<GIANGVIEN> list = new List<GIANGVIEN>();   
         
            try
            {
               
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        GIANGVIEN giangvien = new GIANGVIEN()
                        {
                            STT = Convert.ToInt32(dt.Rows[i]["STT"].ToString()),
                            MAGV = dt.Rows[i]["MAGV"].ToString(),
                            TENGV = dt.Rows[i]["TENGV"].ToString(),
                            NGAYSINH = DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString()),
                            MATKHAU = dt.Rows[i]["MATKHAU"].ToString()
                        };
                        list.Add(giangvien);
                    }
                    foreach (var giangvien in list)
                    {
                        duLieuDAL.GIANGVIEN.Add(giangvien);
                        duLieuDAL.SaveChanges();
                    frmAdmin.frmAdmin_Load(sender, e);
                    }
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
