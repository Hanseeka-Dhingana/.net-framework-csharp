using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 68, 52, 61, 72, 43, 87, 23, 89 };
            int swap;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }


                }
            }

            foreach(int display in arr)
            {
                Console.WriteLine(display);
            }
            Console.WriteLine(arr.Length);
          Console.ReadLine();
          
        }
    }
}
