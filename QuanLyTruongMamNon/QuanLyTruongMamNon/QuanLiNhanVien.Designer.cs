namespace QuanLyTruongMamNon
{
    partial class QuanLiNhanVien
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.barTieuDe = new System.Windows.Forms.Panel();
            this.icon_TB = new System.Windows.Forms.PictureBox();
            this.btnNguoiDung = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.PictureBox();
            this.lbDuongDan = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.barTool = new System.Windows.Forms.Panel();
            this.grTimKiem = new System.Windows.Forms.Panel();
            this.iconTimKiem = new System.Windows.Forms.PictureBox();
            this.boxTimKiem = new System.Windows.Forms.TextBox();
            this.bgTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.duLieu = new System.Windows.Forms.DataGridView();
            this.barTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_TB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).BeginInit();
            this.barTool.SuspendLayout();
            this.grTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.SteelBlue;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(326, 768);
            this.menu.TabIndex = 14;
            // 
            // barTieuDe
            // 
            this.barTieuDe.Controls.Add(this.icon_TB);
            this.barTieuDe.Controls.Add(this.btnNguoiDung);
            this.barTieuDe.Controls.Add(this.btnDangXuat);
            this.barTieuDe.Controls.Add(this.lbDuongDan);
            this.barTieuDe.Controls.Add(this.txtTieuDe);
            this.barTieuDe.Location = new System.Drawing.Point(356, 30);
            this.barTieuDe.Margin = new System.Windows.Forms.Padding(30);
            this.barTieuDe.Name = "barTieuDe";
            this.barTieuDe.Size = new System.Drawing.Size(980, 75);
            this.barTieuDe.TabIndex = 59;
            // 
            // icon_TB
            // 
            this.icon_TB.BackColor = System.Drawing.Color.Transparent;
            this.icon_TB.Image = global::QuanLyTruongMamNon.Properties.Resources.bell;
            this.icon_TB.Location = new System.Drawing.Point(800, 0);
            this.icon_TB.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.icon_TB.Name = "icon_TB";
            this.icon_TB.Size = new System.Drawing.Size(50, 50);
            this.icon_TB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_TB.TabIndex = 22;
            this.icon_TB.TabStop = false;
            this.icon_TB.Click += new System.EventHandler(this.btnXem_click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.Image = global::QuanLyTruongMamNon.Properties.Resources.icon_person;
            this.btnNguoiDung.Location = new System.Drawing.Point(865, 0);
            this.btnNguoiDung.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(50, 50);
            this.btnNguoiDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNguoiDung.TabIndex = 19;
            this.btnNguoiDung.TabStop = false;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Image = global::QuanLyTruongMamNon.Properties.Resources.icon_exit;
            this.btnDangXuat.Location = new System.Drawing.Point(930, 0);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(50, 50);
            this.btnDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDangXuat.TabIndex = 18;
            this.btnDangXuat.TabStop = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_click);
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.lbDuongDan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbDuongDan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDuongDan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDuongDan.Location = new System.Drawing.Point(1, 49);
            this.lbDuongDan.Margin = new System.Windows.Forms.Padding(0);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(398, 25);
            this.lbDuongDan.TabIndex = 15;
            this.lbDuongDan.Text = " Trang chủ ● Quản lí nhân viên";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTieuDe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTieuDe.Location = new System.Drawing.Point(1, 2);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(397, 48);
            this.txtTieuDe.TabIndex = 5;
            this.txtTieuDe.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // barTool
            // 
            this.barTool.BackColor = System.Drawing.Color.Transparent;
            this.barTool.Controls.Add(this.grTimKiem);
            this.barTool.Controls.Add(this.btnThem);
            this.barTool.Location = new System.Drawing.Point(356, 115);
            this.barTool.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.barTool.Name = "barTool";
            this.barTool.Size = new System.Drawing.Size(981, 46);
            this.barTool.TabIndex = 20;
            // 
            // grTimKiem
            // 
            this.grTimKiem.Controls.Add(this.iconTimKiem);
            this.grTimKiem.Controls.Add(this.boxTimKiem);
            this.grTimKiem.Controls.Add(this.bgTimKiem);
            this.grTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Size = new System.Drawing.Size(301, 46);
            this.grTimKiem.TabIndex = 21;
            // 
            // iconTimKiem
            // 
            this.iconTimKiem.BackColor = System.Drawing.Color.White;
            this.iconTimKiem.Image = global::QuanLyTruongMamNon.Properties.Resources.icon_TimKiem2;
            this.iconTimKiem.Location = new System.Drawing.Point(10, 8);
            this.iconTimKiem.Name = "iconTimKiem";
            this.iconTimKiem.Size = new System.Drawing.Size(30, 30);
            this.iconTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconTimKiem.TabIndex = 22;
            this.iconTimKiem.TabStop = false;
            this.iconTimKiem.Click += new System.EventHandler(this.btnTim_click);
            // 
            // boxTimKiem
            // 
            this.boxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.boxTimKiem.Location = new System.Drawing.Point(50, 13);
            this.boxTimKiem.Name = "boxTimKiem";
            this.boxTimKiem.Size = new System.Drawing.Size(236, 22);
            this.boxTimKiem.TabIndex = 25;
            // 
            // bgTimKiem
            // 
            this.bgTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bgTimKiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgTimKiem.Location = new System.Drawing.Point(1, 3);
            this.bgTimKiem.Name = "bgTimKiem";
            this.bgTimKiem.Size = new System.Drawing.Size(300, 40);
            this.bgTimKiem.TabIndex = 22;
            this.bgTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(880, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 40);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnNguoiDung_click);
            // 
            // duLieu
            // 
            this.duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.duLieu.Location = new System.Drawing.Point(356, 170);
            this.duLieu.Margin = new System.Windows.Forms.Padding(30, 0, 0, 30);
            this.duLieu.Name = "duLieu";
            this.duLieu.RowHeadersWidth = 62;
            this.duLieu.Size = new System.Drawing.Size(981, 568);
            this.duLieu.TabIndex = 60;
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.duLieu);
            this.Controls.Add(this.barTool);
            this.Controls.Add(this.barTieuDe);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLiNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).EndInit();
            this.barTool.ResumeLayout(false);
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel barTieuDe;
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.Panel barTool;
        private System.Windows.Forms.Panel grTimKiem;
        private System.Windows.Forms.PictureBox iconTimKiem;
        private System.Windows.Forms.TextBox boxTimKiem;
        private System.Windows.Forms.Button bgTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView duLieu;
        private System.Windows.Forms.PictureBox btnNguoiDung;
        private System.Windows.Forms.PictureBox btnDangXuat;
        private System.Windows.Forms.PictureBox icon_TB;
    }
}