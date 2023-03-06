// Property of: James Crispe
// Created on: Feb 20,2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int col = 10;

            for(int a = 1; a <= row; a++) { 
            for(int b = 1; b <= col; b++) {

                    Console.Write(a * b + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
