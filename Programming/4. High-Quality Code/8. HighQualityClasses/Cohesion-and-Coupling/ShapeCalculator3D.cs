using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class ShapeCalculator3D : ShapeCalculator2D
    {
        public double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double xValue = (x2 - x1) * (x2 - x1);
            double yValue = (y2 - y1) * (y2 - y1);
            double zValue = (z2 - z1) * (z2 - z1);

            double distance = Math.Sqrt(xValue + yValue + zValue);

            return distance;
        }
    }
}