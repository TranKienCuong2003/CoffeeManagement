using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using CoffeeManagement.model;

namespace CoffeeManagement.qrCode
{
    public class QRCodeGenerator
    {
        private const string VIET_QR_API_URL = "https://api.vietqr.io";
        private const string QR_CODE_GENERATE_URL = "v2/generate";

        private static string CLIENT_ID = Properties.Confidential.CLIENT_ID;
        private static string API_KEY = Properties.Confidential.API_KEY;

        private static Size QR_CODE_DEFAULT_SIZE = new Size(200, 200);

        public static Image GenerateQRCode(Bank bank, decimal amount, string addInfo="")
        {
            var client = new RestClient(VIET_QR_API_URL);
            var request = new RestRequest(QR_CODE_GENERATE_URL, Method.Post);

            request.AddHeader("x-client-id", CLIENT_ID);
            request.AddHeader("x-api-key", API_KEY);

            var body = buildQRCodeRequest(bank, amount, addInfo);
            request.AddBody(body);

            var response = client.Execute(request);

            var data = JsonSerializer.Deserialize<QRCodeResponse>(response.Content);

            return ResizeImage(Base64ToImage(data.data.qrDataURL.Replace("data:image/png;base64,", "")), QR_CODE_DEFAULT_SIZE);
        }

        private static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private static Image ResizeImage(Image origin, Size size)
        {
            int sourceWidth = origin.Width;
            
            int sourceHeight = origin.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            
            g.DrawImage(origin, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private static QRCodeRequest buildQRCodeRequest(Bank bank, decimal amount, string addInfo)
        {
            return new QRCodeRequest
            {
                accountNo = bank.AccountNo,
                accountName = bank.AccountName,
                acqId = bank.AcqId,
                amount = amount,
                addInfo = addInfo,
                format = "text",
                template = "compact2"
            };
        }
    }
}
