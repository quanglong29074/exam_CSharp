using Exercise_2.exam2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "Lion ");
            Tiger tiger = new Tiger(100, "Tiger ");

            Animal[] animals = {tiger, lion };

            foreach (var animal in animals)
            {
                animal.Show();
            }
        }
    }
}
