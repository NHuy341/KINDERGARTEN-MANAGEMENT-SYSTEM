using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Aztec.Internal;

namespace QuanLyTruongMamNon
{
    public partial class TheHocSinh : Form
    {
        public TheHocSinh()
        {
            InitializeComponent();
        }
        public TheHocSinh(string maHS, string ten, string sex, string nam, DateTime ngay)
        {
            InitializeComponent();

            hoTen.Text = ten;
            maHocSinh.Text = maHS;
            namHoc.Text = nam;
            ngaySinh.Text = ngay.ToString("dd/MM/yyyy");

            if (sex == "True")
            {
                gioiTinh.Text = "Nam";  
            }
            else
            {
                gioiTinh.Text = "Nữ";
            }

            maVach.Image = creatBarcode(maHocSinh.Text, maVach.Width, maVach.Height);

        }

        static Bitmap creatBarcode(string barcodeText, int width, int height)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = width,
                    Height = height,
                    PureBarcode = true
                }
            };
            Bitmap barcodeBitmap = writer.Write(barcodeText);

            return barcodeBitmap;
        }
    }
}
