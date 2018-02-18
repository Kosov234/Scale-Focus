using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_arrays_1
{
    class Program
    {
        static void Main()
        {
            string[] array = { "Wrong", "Is", "Sentence", "This" };
            int length = array.Length;
            string[] reversed = new string[length];
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }

        }



    }
}