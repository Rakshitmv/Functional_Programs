﻿using System;
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
                    Console.WriteLine("Enter 1: To enter for two dimensional array\n" + "Enter 2: To Exit\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            TwoDimensionalArray twoDimensionalArray = new TwoDimensionalArray();
                            twoDimensionalArray.Matrix();
                            break;
                        case 2:
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