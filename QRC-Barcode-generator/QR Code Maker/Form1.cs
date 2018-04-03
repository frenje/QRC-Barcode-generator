using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Maker
{
    public partial class frmQRCodeMaker : Form
    {
        public frmQRCodeMaker()
        {
            InitializeComponent();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            try
            {
                imgDisplayCodes.Image = barcode.Draw(txtBarcode.Text, 50);
            }
            catch
            {
                MessageBox.Show("Can Not Generate a blank barcode.");
            }
                btnPrint.Visible = true;
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            try
            {
                imgDisplayCodes.Image = qrcode.Draw(txtQRCode.Text, 50);
            }
            catch
            {
                MessageBox.Show("Can Not Generate a blank QRcode.");
            }
                btnPrint.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
