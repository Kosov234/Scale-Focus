using System;
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
            ConvertingToBinary();
 }

        static void ConvertingToBinary()
        {
            int Sumone,n, i, j, binno = 0, dn;
            Console.Write("Enter a number to convert : ");
          n = int.Parse(Console.ReadLine());
            dn = n;
            Sumone = 0;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }
            Console.Write("\nThe Binary of {0} is {1}.\n\n", dn, binno);
            while (binno!=0)
            {if (binno % 2 == 1)
                {
                    Sumone++;
                }
                binno /= 10;
            }
            Console.WriteLine(Sumone);

        }
    }
}