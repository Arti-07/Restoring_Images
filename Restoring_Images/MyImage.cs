using System.Drawing;
using System.IO;
using ImageEditor;
namespace Restoring_Images
{
    public class MyImage
    {
        private string path;
        private readonly Image currentImage;
        private Bitmap bits;
        private Color[,] Data;


        public MyImage(string path)
        {
            this.path = path;
            currentImage = Image.FromFile(path);
            bits = new Bitmap(currentImage);
            Height = bits.Height;
            Width = bits.Width;
            SetPixels();
        }

        public int Width { get; set; }
        public int Height { get; set; }

        private void SetPixels()
        {
            Data = new Color[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Data[i, j] = bits.GetPixel(i, j);
                }
            }
        }

        public Bitmap GetBits()
        {
            return this.bits;
        }

        private Color[,] ChangeToNegative()
        {
            Color[,] tempData = new Color[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    var red = 255 - (Data[i, j].R % 0xff);
                    var green = 255 - (Data[i, j].G % 0xff);
                    var blue = 255 - (Data[i, j].B % 0xff);
                    Color color = Color.FromArgb(red, green, blue);
                    tempData[i, j] = color;
                }
            }

            return tempData;
        }

        private void ChangePixels(Color[,] newPixels)
        {
            var temp = ChangeToNegative();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    bits.SetPixel(i, j, temp[i, j]);
                }
            }
        }

        public Bitmap MakeNegative()
        {
            var temp = ChangeToNegative();
            ChangePixels(temp);
            return bits;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image MakeBlackAndWhite(Image img)
        {
            return img.ToBlackAndWhite();
        }

    }
}