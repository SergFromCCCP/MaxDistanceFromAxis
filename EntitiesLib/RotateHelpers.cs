using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public static class RotateHelpers
    {
        public static System.Drawing.PointF Rotate(this System.Drawing.PointF point, float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            return new System.Drawing.PointF(point.X * cos - point.Y * sin, point.X * sin + point.Y * cos);
        }

        public static System.Drawing.PointF PlusPoint(this System.Drawing.PointF p1, System.Drawing.PointF p2)
        {
            return new System.Drawing.PointF(p1.X + p2.X, p1.Y + p2.Y);
        }
    }

}
