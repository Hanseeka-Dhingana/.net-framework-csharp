using System;


namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 68, 52, 61, 72, 43, 87, 23, 89 };
            

            for(int i = 1; i<arr.Length; i++)
            {
                int key = arr[i];
                int j = i-1;
                while(j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            foreach(int display in arr)
            {
                Console.WriteLine(display);
            }

            Console.ReadKey();
        }
    }
}
