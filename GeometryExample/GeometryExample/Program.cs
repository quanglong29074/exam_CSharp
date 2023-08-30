using GeometryExample.exam1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();

            Console.WriteLine("\nResult:\n" + cylinder.Result());

            Console.ReadLine();
        }
    }
}
