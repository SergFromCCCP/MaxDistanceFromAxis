using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public abstract class BaseShape : IBaseShape
    {
        private string Name;

        protected BaseShape(string name)
        {
            Name = name;
        }

        public abstract double Area { get; }
        public abstract System.Drawing.PointF Center { get; }

        public abstract List<PointF> GetCorners(float rotate);

        public override string ToString()
        {
            return Name;
        }
    }
}
