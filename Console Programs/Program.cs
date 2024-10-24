using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 68, 52, 61, 72, 43, 87, 23, 89 };
            int swap, min_value;

            for(int i=0; i<arr.Length-1; i++)
            {
                min_value = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] < arr[min_value])
                        min_value = j;

                }

                swap = arr[min_value];
                arr[min_value] = arr[i];
                arr[i] = swap;
            }


            foreach(int display in arr)
            {
                Console.WriteLine(display);
            }

            Console.ReadLine();
        }
    }
}
