using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class QuickSort
    {
        private int[] a;

        public QuickSort(int[] inputArray)
        {
            a = inputArray;
        }

        public int Partition(int l, int r)
        {
            int pivot = a[r];
            int i = l;
            for (int j = l; j < r; j++)
            {
                if (a[j] < pivot)
                {
                    Swap(ref a[i], ref a[j]);
                    i++;
                }
            }
            Swap(ref a[i], ref a[r]);
            return i;
        }

        public void Sort(int l, int r)
        {
            if (l < r)
            {
                int pi = Partition(l, r);
                Sort(l, pi - 1);
                Sort(pi + 1, r);
            }
        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void PrintArray()
        {
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main()
        {
            int[] array = { 6, 7, 9, 10, 3, 2, 21, 4 };
            QuickSort quickSort = new QuickSort(array);
            quickSort.Sort(0, array.Length - 1);
            quickSort.PrintArray();
            Console.ReadKey();
        }
    }


}

