namespace QuanLyTruongMamNon
{
    partial class DangNhap
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnQuenMatKhau = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuenMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(0, 46);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(600, 46);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "ĐĂNG NHẬP";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTaiKhoan.Location = new System.Drawing.Point(175, 99);
            this.labelTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(250, 18);
            this.labelTaiKhoan.TabIndex = 1;
            this.labelTaiKhoan.Text = "Tài khoản";
            this.labelTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(179, 178);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(246, 26);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMatKhau.Location = new System.Drawing.Point(175, 154);
            this.labelMatKhau.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(250, 18);
            this.labelMatKhau.TabIndex = 3;
            this.labelMatKhau.Text = "Mật khẩu";
            this.labelMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(179, 232);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(246, 38);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(179, 123);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(246, 26);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnQuenMatKhau.Image = global::QuanLyTruongMamNon.Properties.Resources.icon_QuenMatKhau;
            this.btnQuenMatKhau.Location = new System.Drawing.Point(517, 12);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(30, 30);
            this.btnQuenMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuenMatKhau.TabIndex = 6;
            this.btnQuenMatKhau.TabStop = false;
            this.btnQuenMatKhau.Click += new System.EventHandler(this.btnQuenMatKhau_click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Image = global::QuanLyTruongMamNon.Properties.Resources.buttonCancel;
            this.btnThoat.Location = new System.Drawing.Point(558, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.TabStop = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruongMamNon.Properties.Resources.bg_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.labelTaiKhoan);
            this.Controls.Add(this.labelWelcome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.btnQuenMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox btnQuenMatKhau;
        private System.Windows.Forms.PictureBox btnThoat;
    }
}