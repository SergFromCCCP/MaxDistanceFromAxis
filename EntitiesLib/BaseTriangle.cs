using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class BaseTriangle : BaseShape
    {

        public float Width { get; set; }
        public float Height { get; set; }

        public override double Area => Height * Width/2;

        public override PointF Center => new System.Drawing.PointF(Width / 3, Height / 3);


        public BaseTriangle(float width, float height) : base("Triangle")
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}: width={Width}, height={Height}";
        }

        public override List<PointF> GetCorners(float angle)
        {
            return new List<PointF> {
                new PointF(0,0),
                new PointF(0,Height),
                new PointF(Width,0)
            }.Select(c => c.Rotate(angle)).ToList();
        }
    }
}
