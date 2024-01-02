namespace PhanMemThiTracNghiem.UI.Admin.KyThi
{
    partial class frmChiTietKiThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTietKiThi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel30 = new Guna.UI2.WinForms.Guna2Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.guna2Panel27 = new Guna.UI2.WinForms.Guna2Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbMaKiThi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTenKiThi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.colMakiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMonThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKiThi)).BeginInit();
            this.guna2Panel30.SuspendLayout();
            this.guna2Panel27.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(541, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT KÌ THI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvChiTietKiThi
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvChiTietKiThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietKiThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietKiThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiTietKiThi.ColumnHeadersHeight = 24;
            this.dgvChiTietKiThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiTietKiThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMakiThi,
            this.colMaMonThi,
            this.colMaSV,
            this.colDiem,
            this.colThoiGianBD,
            this.colThoiGianKT,
            this.colThoiGianThi});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietKiThi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiTietKiThi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietKiThi.Location = new System.Drawing.Point(15, 140);
            this.dgvChiTietKiThi.Name = "dgvChiTietKiThi";
            this.dgvChiTietKiThi.RowHeadersVisible = false;
            this.dgvChiTietKiThi.Size = new System.Drawing.Size(1244, 416);
            this.dgvChiTietKiThi.TabIndex = 2;
            this.dgvChiTietKiThi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietKiThi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChiTietKiThi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChiTietKiThi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiTietKiThi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiTietKiThi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietKiThi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietKiThi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvChiTietKiThi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiTietKiThi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietKiThi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiTietKiThi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiTietKiThi.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvChiTietKiThi.ThemeStyle.ReadOnly = false;
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.Height = 22;
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietKiThi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChiTietKiThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietKiThi_CellClick);
            // 
            // guna2Panel30
            // 
            this.guna2Panel30.Controls.Add(this.cbTenKiThi);
            this.guna2Panel30.Controls.Add(this.label27);
            this.guna2Panel30.Location = new System.Drawing.Point(406, 82);
            this.guna2Panel30.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel30.Name = "guna2Panel30";
            this.guna2Panel30.Size = new System.Drawing.Size(387, 53);
            this.guna2Panel30.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(2, 13);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 28);
            this.label27.TabIndex = 0;
            this.label27.Text = "Tên kì thi:";
            // 
            // guna2Panel27
            // 
            this.guna2Panel27.Controls.Add(this.cbMaKiThi);
            this.guna2Panel27.Controls.Add(this.label24);
            this.guna2Panel27.Location = new System.Drawing.Point(15, 82);
            this.guna2Panel27.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel27.Name = "guna2Panel27";
            this.guna2Panel27.Size = new System.Drawing.Size(387, 53);
            this.guna2Panel27.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(2, 13);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 28);
            this.label24.TabIndex = 0;
            this.label24.Text = "Mã kì thi:";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1221, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1170, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // cbMaKiThi
            // 
            this.cbMaKiThi.BackColor = System.Drawing.Color.Transparent;
            this.cbMaKiThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaKiThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKiThi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaKiThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaKiThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaKiThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaKiThi.ItemHeight = 30;
            this.cbMaKiThi.Location = new System.Drawing.Point(101, 8);
            this.cbMaKiThi.Name = "cbMaKiThi";
            this.cbMaKiThi.Size = new System.Drawing.Size(218, 36);
            this.cbMaKiThi.TabIndex = 1;
            // 
            // cbTenKiThi
            // 
            this.cbTenKiThi.BackColor = System.Drawing.Color.Transparent;
            this.cbTenKiThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenKiThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKiThi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenKiThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenKiThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenKiThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTenKiThi.ItemHeight = 30;
            this.cbTenKiThi.Location = new System.Drawing.Point(105, 8);
            this.cbTenKiThi.Name = "cbTenKiThi";
            this.cbTenKiThi.Size = new System.Drawing.Size(218, 36);
            this.cbTenKiThi.TabIndex = 1;
            // 
            // colMakiThi
            // 
            this.colMakiThi.HeaderText = "Mã kì thi";
            this.colMakiThi.Name = "colMakiThi";
            // 
            // colMaMonThi
            // 
            this.colMaMonThi.HeaderText = "Mã môn thi";
            this.colMaMonThi.Name = "colMaMonThi";
            // 
            // colMaSV
            // 
            this.colMaSV.HeaderText = "Mã sinh viên";
            this.colMaSV.Name = "colMaSV";
            // 
            // colDiem
            // 
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.Name = "colDiem";
            // 
            // colThoiGianBD
            // 
            this.colThoiGianBD.HeaderText = "Thời gian bắt đầu";
            this.colThoiGianBD.Name = "colThoiGianBD";
            // 
            // colThoiGianKT
            // 
            this.colThoiGianKT.HeaderText = "Thời gian kết thúc";
            this.colThoiGianKT.Name = "colThoiGianKT";
            // 
            // colThoiGianThi
            // 
            this.colThoiGianThi.HeaderText = "Thời gian thi";
            this.colThoiGianThi.Name = "colThoiGianThi";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 100);
            this.panel2.TabIndex = 4;
            // 
            // frmChiTietKiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1275, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel30);
            this.Controls.Add(this.guna2Panel27);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.dgvChiTietKiThi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiTietKiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietKiThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChiTietKiThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKiThi)).EndInit();
            this.guna2Panel30.ResumeLayout(false);
            this.guna2Panel30.PerformLayout();
            this.guna2Panel27.ResumeLayout(false);
            this.guna2Panel27.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTietKiThi;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel30;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel27;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenKiThi;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaKiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMonThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianThi;
        private System.Windows.Forms.Panel panel2;
    }
}