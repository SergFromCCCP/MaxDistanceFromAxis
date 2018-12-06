using System.Collections.Generic;

namespace EntitiesLib
{
    public interface IBaseShape
    {
        double Area { get; }
        System.Drawing.PointF Center { get; }
        List<System.Drawing.PointF> GetCorners(float angle);

    }
}
