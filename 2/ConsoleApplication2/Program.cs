﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = 0;
            for (int f=n;f<=m;f++)
            {
                s = s + f;
            }
            Console.WriteLine(s);
        }
    }
}
