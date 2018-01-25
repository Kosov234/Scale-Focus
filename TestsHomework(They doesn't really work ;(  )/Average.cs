using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   public static class BasicMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(0)); ;
        }
        public static int Average(int n)
        {
            if (n==0)
            {
                throw new System.DivideByZeroException();
                Console.WriteLine("NO :(");
            }
            int f = 0;
            for (int s = 0; s <= n; s++)
            {
                f = f + s;
            }
            int result = f / n;
            return result;
        }
    }
    }
