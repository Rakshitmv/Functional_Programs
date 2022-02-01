using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter 1: To enter for two dimensional array\n" +  "Enter 2: To get sum of 3 added integer as zero\n" + "Enter 3: Calculate Distance\n" + "Enter 4: To get Quadratic roots\n" + "Enter 5: To get wind temperature\n" + "Enter 6: To Exit\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            TwoDimensionalArray twoDimensionalArray = new TwoDimensionalArray();
                            twoDimensionalArray.Matrix();
                            break;
                        case 2:
                            SumAddsToZero sumAddsToZero = new SumAddsToZero();
                            sumAddsToZero.SumofThreeZero();
                            break;
                        case 3: 
                            Distance distance = new Distance();
                            distance.DistanceCal();
                            break;
                        case 4:
                            QuadraticRoots quadraticRoots = new QuadraticRoots();
                            quadraticRoots.Roots();
                            break;
                        case 5:
                            WindChill windChill = new WindChill();
                            windChill.Wind();
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please enter the correct option\n");
                            break;
                    }
                }
            }
        }
    }
}
