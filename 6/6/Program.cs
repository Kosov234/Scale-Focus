using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            for (int f = 1; f <= n; f++)
            {
                s = s*f;
            }
            Console.WriteLine(s);
        }
    }
}
