using System;
using System.Drawing.Imaging;
using System.IO;

namespace QuanLyBanHang.DTO.UIImage
{
    public class Image
    {
        public Image ByteArrayToImage(byte[] byteArr)
        {
            if (byteArr != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArr))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            else
            {
                return null;
            }

        }

        private static Image FromStream(MemoryStream ms)
        {
            throw new NotImplementedException();
        }

        byte[] ConvertImage(Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void Save(MemoryStream ms, ImageFormat jpeg)
        {
            throw new NotImplementedException();
        }
    }
}
