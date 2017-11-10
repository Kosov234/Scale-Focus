using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int rows = 0;
            rows= int.Parse(Console.ReadLine());   
   for(i=1;i<=rows;i++)
   {
	for(j=1;j<=i;j++)
	   Console.Write("*");
	Console.Write("\n");
   }
  }    
}
}
