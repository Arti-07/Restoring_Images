using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ImageEditor;

namespace Restoring_Images
{
    public class InverseFiltering
    {
        /// <summary>
        /// Инверстная фильтрация
        /// </summary>
        /// <param name="sourceImage"> Искаженное изображение </param>
        /// <param name="filter"> Оператор искажения PSF (Point Spread Function)</param>
        /// <param name="outFilter"> Восстанавливающий фильтр </param>
        /// <returns></returns>
        public static Image Filtering(Image sourceImage, ConvolutionFilter filter, out ConvolutionFilter outFilter)
        {
            // Перевод PSF в частотную область (OTF)
            Complex[,] otf = OpticalTransferFunction.Psf2otf(filter);
            // Получение обратного RSF
            for (int i = 0; i < otf.GetLength(0); i++)
            {
                for (int j = 0; j < otf.GetLength(1); j++)
                {
                    otf[i, j] = 1f / otf[i, j];
                }
            }
            // Перевод OTF обратно в пространственную область (PSF) 
            outFilter = OpticalTransferFunction.Otf2psf(otf);
            //быстрая свёртка изображения с обратной PSF
            Image result = outFilter.FastConvolution(sourceImage);
            return result;
        }
    }
}
