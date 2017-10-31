using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            FillArray(numbers);

            WriteArray(numbers);

            SortInsertion(numbers);
            // SortSelection(numbers);
            // SortBubble(numbers);
            // SortQuick(numbers);
            // SortMerge(numbers);

            WriteArray(numbers);
        }

        // TODO: do mergesort
        private static void SortMerge(int[] numbers)
        {
        }

        // TODO: do quicksort
        private static void SortQuick(int[] numbers)
        {
        }

        private static void SortBubble(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        private static void SortSelection(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int min = i;

                // TODO: do more effective
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[min] > numbers[j])
                    {
                        min = j;
                    }
                }

                int temp = numbers[min];
                numbers[min] = numbers[i];
                numbers[i] = temp;
            }
        }

        private static void FillArray(int[] numbers)
        {
            WriteLine("========= Fill Array [{0}]=========", numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                int number;

                do
                {
                    Write("\n{0} : ", i + 1);
                }
                while (!Int32.TryParse(ReadLine(), out number));

                numbers[i] = number;
            }

            WriteLine("\n========= Fill Array [{0}]=========", numbers.Length);
        }

        private static void WriteArray(int[] numbers)
        {
            WriteLine("========= Array =========\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                WriteLine("{0}\t->\t{1}", i, numbers[i]);
            }
            WriteLine("\n========= Array =========");
        }

        private static void SortInsertion(int[] numbers)
        {
            int holePosition;
            int valueToInsert;

            for (int i = 0; i < numbers.Length; i++)
            {
                valueToInsert = numbers[i];
                holePosition = i;

                while(holePosition > 0 && numbers[ holePosition - 1 ] > valueToInsert)
                {
                    numbers[holePosition] = numbers[holePosition - 1];
                    holePosition = holePosition - 1;
                }

                numbers[holePosition] = valueToInsert;
            }
        }
    }
}
