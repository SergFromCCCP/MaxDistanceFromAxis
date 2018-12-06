using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class ConcreteParameters
    {
        public System.Drawing.PointF Location { get; private set; }
        public float Rotate { get; private set; }
        public int RotateDegree { get; private set; }

        public ConcreteParameters(PointF location, float rotate)
        {
            Location = location;
            Rotate = rotate;
        }

        public ConcreteParameters(float X, float Y, float rotate) : this(new System.Drawing.PointF(X, Y), rotate)
        {
        }
        public ConcreteParameters(float X, float Y, int rotateDegree) : this(new System.Drawing.PointF(X, Y),
            (float)(rotateDegree * Math.PI / 180))
        {
            RotateDegree = rotateDegree;
        }

        public override string ToString()
        {
            return $"Location: {Location.ToString()}, Angle: {RotateDegree} oC";
        }
    }
}
