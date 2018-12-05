using System;
using System.Collections.Generic;
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

        public override string ToString()
        {
            return Name;
        }
    }

    public interface IBaseShape
    {
        double Area { get; }
        System.Drawing.PointF Center { get; }

    }
}
