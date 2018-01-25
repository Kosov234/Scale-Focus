using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class BasicMethods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(3, 400000));
        }
        public static int Sum(int n,int m)
        {
            int s = 0;
            for (int f = n; f <= m; f++)
            {
                s = s + f;
            }
            int result = s;
            return result;
        }

    }
}
