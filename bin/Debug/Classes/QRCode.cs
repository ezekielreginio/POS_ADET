using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace POS_ADET.Classes
{
    public static class QRCode
    {
        public static Bitmap generateQR(String qrString, String fileName, bool save = true)
        {

            string filePath = @"C:\qr\" + fileName + ".png";

            BarcodeWriter barcodeW = new BarcodeWriter();

            barcodeW.Format = BarcodeFormat.QR_CODE;

            if(save)
                barcodeW.Write(qrString).Save(filePath);

            Bitmap qr = new Bitmap(filePath);

            return qr;
        }
    }
}
