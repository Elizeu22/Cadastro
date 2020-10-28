using System;

namespace ConsoleApp1
{
    class Program
    {

        public static void Sawp(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

        public static int Part(int[] arr, int left, int right)
        {
            
            int pivot = arr[right];


            int i = left-1;
            int j = left;

            while (j < right)
            {
                if (pivot > arr[j])
                {
                    i++;
                    Sawp(arr, i, j);
                   
                }

                j++;
            }


            Sawp(arr, i+1, j);

            return i;
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Part(arr, start, end);

                QuickSort(arr, start, i);
                QuickSort(arr, i + 1, arr.Length-1);
            }
        }


        static void Main(string[] args)
        {



            int[] arr = { 7, 2, 1, 8, 6, 3, 5, 4 };

            QuickSort(arr, 0, arr.Length - 1);

        }
    }







 


}
