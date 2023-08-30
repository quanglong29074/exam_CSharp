using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.exam2
{
    public class Animal
    {
        protected double Weight { get; set; }
        protected string Name { get; set; }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}
