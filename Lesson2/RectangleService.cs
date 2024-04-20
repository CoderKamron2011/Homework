using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class RectangleService : IShapeCalculator
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public RectangleService(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double ShaklUzunligi()
        {
            return 2 * (this.Height + this.Width);

        }
        public double Yuza()
        {
            return (this.Height * this.Width);
        }
    }
}
