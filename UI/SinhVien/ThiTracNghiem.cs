using PhanMemThiTracNghiem.DAL.Model;
using PhanMemThiTracNghiem.UI.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PhanMemThiTracNghiem
{
    public partial class ThiTracNghiem : Form
    {
        private readonly SINHVIEN sinhVien;
        public ThiTracNghiem(SINHVIEN sv)
        {
            InitializeComponent();
            sinhVien = sv;

        }

        internal void HienThi(float diemThi, int demSoCauDung, List<int> luuBaiLam)
        {
            // Số câu đúng
            lblSoCauDung.Text = demSoCauDung.ToString() + "/" + luuBaiLam.Count().ToString();

            // Số điểm
            lblDiem.Text = diemThi.ToString();

            // TẠO Ô ĐÚNG SAI & Tô màu cho ô có câu trả lời đúng
            int x = 25, y = 25;
            for (int i = 0; i < luuBaiLam.Count(); i++)
            {
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Text = (i + 1).ToString();
                btn.TextAlign = ContentAlignment.MiddleCenter;
                //btn.Tag = item.MaSoBan;
                btn.Name = i.ToString();
                btn.Size = new Size(53, 46);
                btn.BackColor = Color.FromArgb(255, 72, 81);
                btn.Focus();

                pnlHienThiODungSai.Controls.Add(btn);

                btn.BringToFront();

                x += 80;

                if ((i + 1) % 10 == 0)
                {
                    y += 70;
                    x = 25;
                }
                if (luuBaiLam[i] == 1)
                {
                    btn.BackColor = Color.Green;
                }
            }

        }
        private void TaoNut(int i, ref int x, ref int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Font = new Font("Be Vietnam Pro", 10);
            btn.Text = i.ToString();
            //btn.Tag = item.MaSoBan;
            btn.Name = i.ToString();
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Size = new Size(53, 46);
            btn.BackColor = Color.Red;
            btn.Focus();
            //btn.Click += Btn_Click;
            //btn.Click += Btn_Oder;

            pnlHienThiODungSai.Controls.Add(btn);

            btn.BringToFront();
        }

        private void ThiTracNghiem_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            frmSinhVien frmSV = new frmSinhVien(sinhVien, i);
            this.Hide();
            frmSV.ShowDialog();
            this.Close();

        }
    }
}
