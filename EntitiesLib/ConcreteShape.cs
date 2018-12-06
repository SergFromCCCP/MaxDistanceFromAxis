using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib
{
    public class ConcreteShape : IMaxDistance
    {
        private BaseShape baseShape;
        private ConcreteParameters parameters;

        public ConcreteShape(BaseShape baseShape, ConcreteParameters parameters)
        {
            this.baseShape = baseShape;
            this.parameters = parameters;
        }

        public PointF GetMaxDistance(PointF point)
        {
            var corners = baseShape.GetCorners(parameters.Rotate).Select(c => c.PlusPoint(parameters.Location));
            var max = new PointF(
                corners.Max(c => Math.Abs(c.X - point.X)), 
                corners.Max(c => Math.Abs(c.Y - point.Y))
                );
            return max;
        }

        public override string ToString()
        {
            return baseShape.ToString() + "\n" + parameters.ToString();
        }
    }
}
