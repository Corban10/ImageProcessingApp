using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace ImageProcessingApp
{
    class ImageHandler
    {
        //public void SetColorFilter(ColorFilterTypes colorFilterType)
        //{
        //    Bitmap temp = (Bitmap)_currentBitmap;
        //    Bitmap bmap = (Bitmap)temp.Clone();
        //    Color c;
        //    for (int i = 0; i < bmap.Width; i++)
        //    {
        //        for (int j = 0; j < bmap.Height; j++)
        //        {
        //            c = bmap.GetPixel(i, j);
        //            int nPixelR = 0;
        //            int nPixelG = 0;
        //            int nPixelB = 0;
        //            if (colorFilterType == ColorFilterTypes.Red)
        //            {
        //                nPixelR = c.R;
        //                nPixelG = c.G - 255;
        //                nPixelB = c.B - 255;
        //            }
        //            else if (colorFilterType == ColorFilterTypes.Green)
        //            {
        //                nPixelR = c.R - 255;
        //                nPixelG = c.G;
        //                nPixelB = c.B - 255;
        //            }
        //            else if (colorFilterType == ColorFilterTypes.Blue)
        //            {
        //                nPixelR = c.R - 255;
        //                nPixelG = c.G - 255;
        //                nPixelB = c.B;
        //            }
        //            nPixelR = Math.Max(nPixelR, 0);
        //            nPixelR = Math.Min(255, nPixelR);

        //            nPixelG = Math.Max(nPixelG, 0);
        //            nPixelG = Math.Min(255, nPixelG);

        //            nPixelB = Math.Max(nPixelB, 0);
        //            nPixelB = Math.Min(255, nPixelB);

        //            bmap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
        //              (byte)nPixelG, (byte)nPixelB));
        //        }
        //    }
        //    _currentBitmap = (Bitmap)bmap.Clone();
        //}
    }
}
