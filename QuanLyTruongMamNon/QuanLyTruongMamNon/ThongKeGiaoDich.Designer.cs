namespace QuanLyTruongMamNon
{
    partial class ThongKeGiaoDich
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
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.toolBar = new System.Windows.Forms.Panel();
            this.lbMuc = new System.Windows.Forms.Label();
            this.muc = new System.Windows.Forms.ComboBox();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.duLieu = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
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
            this.txtTieuDe.Text = "THỐNG KÊ GIAO DỊCH";
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
            this.lbDuongDan.Text = " Trang chủ ● Quản lí ngân sách ● Thống kê giao dịch";
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
            this.icon_TB.TabIndex = 21;
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
            // tuNgay
            // 
            this.tuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tuNgay.Location = new System.Drawing.Point(0, 26);
            this.tuNgay.Margin = new System.Windows.Forms.Padding(20);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(250, 29);
            this.tuNgay.TabIndex = 29;
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.Transparent;
            this.toolBar.Controls.Add(this.lbMuc);
            this.toolBar.Controls.Add(this.muc);
            this.toolBar.Controls.Add(this.lbTuNgay);
            this.toolBar.Controls.Add(this.denNgay);
            this.toolBar.Controls.Add(this.lbDenNgay);
            this.toolBar.Controls.Add(this.tuNgay);
            this.toolBar.Location = new System.Drawing.Point(356, 115);
            this.toolBar.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(980, 62);
            this.toolBar.TabIndex = 19;
            // 
            // lbMuc
            // 
            this.lbMuc.BackColor = System.Drawing.Color.Transparent;
            this.lbMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMuc.Location = new System.Drawing.Point(727, 5);
            this.lbMuc.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.lbMuc.Name = "lbMuc";
            this.lbMuc.Size = new System.Drawing.Size(171, 18);
            this.lbMuc.TabIndex = 34;
            this.lbMuc.Text = "Mục";
            this.lbMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // muc
            // 
            this.muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muc.FormattingEnabled = true;
            this.muc.Location = new System.Drawing.Point(730, 27);
            this.muc.Margin = new System.Windows.Forms.Padding(20);
            this.muc.Name = "muc";
            this.muc.Size = new System.Drawing.Size(250, 28);
            this.muc.TabIndex = 33;
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTuNgay.Location = new System.Drawing.Point(-3, 5);
            this.lbTuNgay.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(99, 18);
            this.lbTuNgay.TabIndex = 20;
            this.lbTuNgay.Text = "Từ ngày";
            this.lbTuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // denNgay
            // 
            this.denNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.denNgay.Location = new System.Drawing.Point(365, 26);
            this.denNgay.Margin = new System.Windows.Forms.Padding(20);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(250, 29);
            this.denNgay.TabIndex = 32;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDenNgay.Location = new System.Drawing.Point(362, 5);
            this.lbDenNgay.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(171, 18);
            this.lbDenNgay.TabIndex = 20;
            this.lbDenNgay.Text = "Đến ngày";
            this.lbDenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // ThongKeGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.duLieu);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.barTieuDe);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê giao dịch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).EndInit();
            this.toolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.Panel barTieuDe;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.DataGridView duLieu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.PictureBox btnNguoiDung;
        private System.Windows.Forms.PictureBox btnDangXuat;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label lbMuc;
        private System.Windows.Forms.ComboBox muc;
        private System.Windows.Forms.PictureBox icon_TB;
    }
}