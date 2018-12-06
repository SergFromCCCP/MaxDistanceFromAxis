using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class BaseSector : BaseShape
    {
        public BaseSector(float radius, float angle) : base("Сектор")
        {
            Radius = radius;
            Angle = angle;
        }

        public BaseSector(float radius, int angleDegree) : this(radius, (float)(angleDegree * Math.PI / 180))
        {
            AngleDegree = angleDegree;
        }

        public float Radius { get; set; }
        public float Angle { get; set; }
        public int AngleDegree { get; set; }

        public override double Area => Angle * Radius * Radius / 2;

        public override PointF Center => new PointF(0, 0);

        public override List<PointF> GetCorners(float rotate)
        {
            var t = new List<PointF> {
                new PointF(0,0),
                new PointF(Radius,0),
                new PointF((float)(Radius*Math.Cos(Angle)),(float)(Radius*Math.Sin(Angle)))
            }.Select(c => c.Rotate(rotate)).ToList();
            var koef = new float[] { 0, 1, 0, -1, 0 };
            for (int i = 0; i < 4; i++)
                if (IsBetween(i * (float)(Math.PI / 2), rotate, rotate + Angle))
                    t.Add(new PointF(Radius * koef[i + 1], Radius * koef[i]));
            return t;
        }
        private bool IsBetween(float value, float min, float max) => (value >= min) && (value <= max);

    }
}
