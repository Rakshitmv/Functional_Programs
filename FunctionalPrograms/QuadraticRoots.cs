using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuadraticRoots
    {
        public void Roots()
        {
            Console.WriteLine("Enter the a,b,c values");
            double a, b, c;
            string input = Console.ReadLine();
            string[] inp = input.Split(' ');
            a = int.Parse(inp[0]);
            b = int.Parse(inp[1]);
            c = int.Parse(inp[2]);
            Double discriminant = Math.Sqrt(b * b - 4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("Roots are Imaginary\n");
            }
            else
            {
                double alpha = (-b + (discriminant)) / 2 * a;
                double beta = (-b - (discriminant)) / 2 * a;
                Console.WriteLine("The roots are :" + alpha + " " + beta + "\n");
            }
        }
    }
}
