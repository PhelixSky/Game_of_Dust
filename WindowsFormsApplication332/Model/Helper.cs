using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;

namespace Game_of_Dust.Model
{
    static class Helper
    {
        public static PointF Mult(this PointF p, float koeff)
        {
            return new PointF(p.X * koeff, p.Y * koeff);
        }

        public static PointF Add(this PointF p1, PointF p2, float koeff = 1f)
        {
            return new PointF(p1.X + p2.X * koeff, p1.Y + p2.Y * koeff);
        }

        public static PointF PointF(this Random rnd, float fromX, float toX, float fromY, float toY)
        {
            return new PointF((float)(rnd.NextDouble() * (toX - fromX) + fromX),
                              (float)(rnd.NextDouble() * (toY - fromY) + fromY));
        }

        public static void SetPixels(this Bitmap bmp, byte[] pixels)
        {
            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bmpData.Scan0, pixels.Length);
            bmp.UnlockBits(bmpData);
        }
    }
}
