using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.exam1
{
    public class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;

        }

        public string Result()
        {
            return $"Base Area: {Radius * Radius * Math.PI}\n" +
                   $"Lateral Area: {2 * Math.PI * Radius * Height}\n" +
                   $"Total Area: {2 * Math.PI * Radius * (Height + Radius)}\n" +
                   $"Volume: {Math.PI * Radius * Radius * Height}";
        }
    }
}
