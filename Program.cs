﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.Write("informe o valor da base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("informe o valor da altura: ");
            h = int.Parse(Console.ReadLine());
            a = (b * h) / 2;
            Console.WriteLine("o valor  da área é:{0} ", a);
        }
    }
}
