using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class SquareServise : IShapeCalculator
    {

        public double Radius { get; set; }
        public SquareServise(double radius)
        {
            this.Radius = radius;

        }
        public double ShaklUzunligi()
        {
            return 2 * (Math.PI * Radius);

        }
        public double Yuza()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }

    }
}
