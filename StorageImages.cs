using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOfProd
{
    class StorageImages
    {
        public Image Food = Image.FromFile(@"C:\Users\Danik\source\repos\ShopOfProd\images\food.png");
        public Image Inter = Image.FromFile(@"C:\Users\Danik\source\repos\ShopOfProd\images\interface.png");
        public Image Start = Image.FromFile(@"C:\Users\Danik\source\repos\ShopOfProd\images\start.png");
        public Image User = Image.FromFile(@"C:\Users\Danik\source\repos\ShopOfProd\images\user-icon.png");
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }
    }
}
