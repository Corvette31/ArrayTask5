using System;

namespace ArrayTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 30;
            int itemMinValue = 1;
            int itemMaxValue = 6;
            int[] array = new int[arraySize];
            int maxRepetitions = 1;
            int currentRepetitions = 1;
            int repetitionNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(itemMinValue, itemMaxValue);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i-1])
                {
                    currentRepetitions++;
                    if (currentRepetitions > maxRepetitions)
                    {
                        maxRepetitions = currentRepetitions;
                        repetitionNumber = array[i];
                    }
                }
                else
                {
                    currentRepetitions = 1;
                }
            }

            Console.WriteLine($"число {repetitionNumber} повторяется большее число раз подряд");
        }
    }
}
