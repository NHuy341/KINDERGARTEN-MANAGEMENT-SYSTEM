namespace QuanLyTruongMamNon
{
    partial class QuanLiDiemDanh
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
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.lbDuongDan = new System.Windows.Forms.Label();
            this.barTieuDe = new System.Windows.Forms.Panel();
            this.icon_TB = new System.Windows.Forms.PictureBox();
            this.btnNguoiDung = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.bgMaHocSinh = new System.Windows.Forms.Button();
            this.bgThoiGian = new System.Windows.Forms.Button();
            this.maHocSinh = new System.Windows.Forms.TextBox();
            this.thoiGian = new System.Windows.Forms.DateTimePicker();
            this.toolBar = new System.Windows.Forms.Panel();
            this.labelMaHocSinh = new System.Windows.Forms.Label();
            this.duLieu = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.labelThoiGian = new System.Windows.Forms.Label();
            this.barTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_TB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).BeginInit();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            this.SuspendLayout();
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
            this.txtTieuDe.Text = "QUẢN LÍ ĐIỂM DANH";
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
            this.lbDuongDan.Text = " Trang chủ ● Quản lí điểm danh";
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
            this.barTieuDe.TabIndex = 15;
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
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(879, 20);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 40);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // bgMaHocSinh
            // 
            this.bgMaHocSinh.BackColor = System.Drawing.Color.White;
            this.bgMaHocSinh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bgMaHocSinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bgMaHocSinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bgMaHocSinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bgMaHocSinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgMaHocSinh.Location = new System.Drawing.Point(138, 19);
            this.bgMaHocSinh.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.bgMaHocSinh.Name = "bgMaHocSinh";
            this.bgMaHocSinh.Size = new System.Drawing.Size(724, 40);
            this.bgMaHocSinh.TabIndex = 27;
            this.bgMaHocSinh.UseVisualStyleBackColor = false;
            // 
            // bgThoiGian
            // 
            this.bgThoiGian.BackColor = System.Drawing.Color.White;
            this.bgThoiGian.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bgThoiGian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bgThoiGian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bgThoiGian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bgThoiGian.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgThoiGian.Location = new System.Drawing.Point(0, 20);
            this.bgThoiGian.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.bgThoiGian.Name = "bgThoiGian";
            this.bgThoiGian.Size = new System.Drawing.Size(118, 40);
            this.bgThoiGian.TabIndex = 28;
            this.bgThoiGian.UseVisualStyleBackColor = false;
            // 
            // maHocSinh
            // 
            this.maHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maHocSinh.Location = new System.Drawing.Point(148, 28);
            this.maHocSinh.Name = "maHocSinh";
            this.maHocSinh.Size = new System.Drawing.Size(702, 22);
            this.maHocSinh.TabIndex = 25;
            // 
            // thoiGian
            // 
            this.thoiGian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.thoiGian.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thoiGian.Location = new System.Drawing.Point(5, 26);
            this.thoiGian.Name = "thoiGian";
            this.thoiGian.Size = new System.Drawing.Size(107, 29);
            this.thoiGian.TabIndex = 29;
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.Transparent;
            this.toolBar.Controls.Add(this.labelMaHocSinh);
            this.toolBar.Controls.Add(this.thoiGian);
            this.toolBar.Controls.Add(this.maHocSinh);
            this.toolBar.Controls.Add(this.bgThoiGian);
            this.toolBar.Controls.Add(this.bgMaHocSinh);
            this.toolBar.Controls.Add(this.btnThem);
            this.toolBar.Location = new System.Drawing.Point(356, 115);
            this.toolBar.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(980, 62);
            this.toolBar.TabIndex = 19;
            // 
            // labelMaHocSinh
            // 
            this.labelMaHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.labelMaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHocSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMaHocSinh.Location = new System.Drawing.Point(138, 2);
            this.labelMaHocSinh.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.labelMaHocSinh.Name = "labelMaHocSinh";
            this.labelMaHocSinh.Size = new System.Drawing.Size(171, 18);
            this.labelMaHocSinh.TabIndex = 20;
            this.labelMaHocSinh.Text = "Mã học sinh";
            this.labelMaHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // duLieu
            // 
            this.duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.duLieu.Location = new System.Drawing.Point(356, 185);
            this.duLieu.Margin = new System.Windows.Forms.Padding(30, 0, 0, 30);
            this.duLieu.Name = "duLieu";
            this.duLieu.RowHeadersWidth = 62;
            this.duLieu.Size = new System.Drawing.Size(980, 553);
            this.duLieu.TabIndex = 18;
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
            // labelThoiGian
            // 
            this.labelThoiGian.BackColor = System.Drawing.Color.Transparent;
            this.labelThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelThoiGian.Location = new System.Drawing.Point(358, 117);
            this.labelThoiGian.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.labelThoiGian.Name = "labelThoiGian";
            this.labelThoiGian.Size = new System.Drawing.Size(99, 18);
            this.labelThoiGian.TabIndex = 20;
            this.labelThoiGian.Text = "Thời gian";
            this.labelThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuanLiDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.labelThoiGian);
            this.Controls.Add(this.duLieu);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.barTieuDe);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLiDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí điểm danh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.Panel barTieuDe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button bgMaHocSinh;
        private System.Windows.Forms.Button bgThoiGian;
        private System.Windows.Forms.TextBox maHocSinh;
        private System.Windows.Forms.DateTimePicker thoiGian;
        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.DataGridView duLieu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label labelMaHocSinh;
        private System.Windows.Forms.Label labelThoiGian;
        private System.Windows.Forms.PictureBox btnNguoiDung;
        private System.Windows.Forms.PictureBox btnDangXuat;
        private System.Windows.Forms.PictureBox icon_TB;
    }
}