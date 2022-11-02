using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Restoring_Images
{
    internal class MyBlurs
    {
        public static double[,] GetNormalizedMatrix(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            double[,] resultMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrix[i, j] / sum;
                }
            }
            return resultMatrix;
        }

        public static double[,] GausBlur(int lenght, double sigma)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int a = (lenght - 1) / 2;
            double distance = 0;
            double constant = 1d / (2 * Math.PI * sigma * sigma);

            for (int y = -a; y <= a; y++)
            {
                for (int x = -a; x <= a; x++)
                {
                    distance = (y * y + x * x) / (2 * sigma * sigma);
                    kernel[y + a, x + a] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + a, x + a];
                }
            }

            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }
            return kernel;
        }

        public static double[,] MotionBlurLeftToRight(int lenght)
        {
            double[,] kernel = new double[lenght, lenght];
            for (int i = 0; i < lenght; i++)
            {
                kernel[i, i] = 1;
            }
            return GetNormalizedMatrix(kernel);
        }
        public static double[,] MotionBlur(int lenght)
        {
            double[,] kernel = new double[lenght, lenght];
            for (int i = 0; i < lenght; i++)
            {
                kernel[i, i] = 1;
                kernel[i, lenght - i - 1] = 1;
            }
            return GetNormalizedMatrix(kernel);
        }
        public static double[,] MotionBlurRightToleft(int lenght)
        {
            double[,] kernel = new double[lenght, lenght];
            for (int i = 0; i < lenght; i++)
            {
                kernel[i, lenght - i - 1] = 1;
            }
            return GetNormalizedMatrix(kernel);
        }

        public static double[,] BoxBlur(int radius)
        {
            int n = 2 * radius + 1;
            double[,] kernel = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kernel[i, j] = 1;
                }
            }
            return GetNormalizedMatrix(kernel);
        }

        public static double[,]HorizontalBlur(int lenght)
        {
            double[,] kernel = new double[lenght, lenght];
            int centralRowInx = (int)(lenght / 2);
            for (int i = 0; i < lenght; i++)
            {
                kernel[centralRowInx, i] = 1;
            }
            return GetNormalizedMatrix(kernel);
        }
        public static double[,]VerticalBlur(int lenght)
        {
            double[,] kernel = new double[lenght, lenght];
            int centralRowInx = (int)(lenght / 2);
            for (int i = 0; i < lenght; i++)
            {
                kernel[i, centralRowInx] = 1;
            }
            return GetNormalizedMatrix(kernel);
        }
        public static double[,]CustomBlur(int lenght)
        {
            double[,] kernel = { { 0, 0, 0 }, { 0, 1.0, 0 }, { 0, 0, 0 } };
            return kernel;
        }
        public static Bitmap Convolve(Bitmap srcImage, double[,] kernel)
        {

            int width = srcImage.Width;
            int height = srcImage.Height;

            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);

            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int foff = (kernel.GetLength(0) - 1) / 2;
            int kCenter = 0;
            int kPixel = 0;

            for (int y = foff; y < height - foff; y++)
            {
                for (int x = foff; x < width - foff; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }
                    kCenter = y * srcData.Stride + x * 4;
                    for (int fy = -foff; fy <= foff; fy++)
                    {
                        for (int fx = -foff; fx <= foff; fx++)
                        {
                            kPixel = kCenter + fy * srcData.Stride + fx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += buffer[kPixel + c] * kernel[fy + foff, fx + foff];
                            }
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kCenter + c] = (byte)rgb[c];
                    }
                    result[kCenter + 3] = 255;
                }
            }
            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height),
        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);

            return resultImage;
        }
    }
}
