using System;
using System.Linq;

namespace SortingBubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите числа через пробел: ");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arraySort = Sort(array);

            Print(arraySort);

            Console.ReadKey();
        }

        private static void Print(int[] arraySort)
        {
            foreach(int n in arraySort)
            {
                Console.Write(n + " ");
            }
        }

        private static int[] Sort(int[] array)
        {
            for(int j = 0; j < array.Length; j++)
            {
                bool changeNums = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int buf = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = buf;
                        changeNums = true;
                    }
                }
                if (changeNums == false)
                    return array;
            }

            return array;
        }
    }
}
