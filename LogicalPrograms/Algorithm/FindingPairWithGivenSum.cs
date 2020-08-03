using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicalPrograms.Algorithm
{
    internal class FindingPairWithGivenSum
    {
        /// <summary>
        /// This has Time Complexity O(n^2)
        /// </summary>
        /// <param name="inputArray">integer array</param>
        /// <param name="sum">sum</param>
        public static void FindTheSumPair(int[] inputArray, int sum)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == sum)
                    {
                        Console.WriteLine($"The sum is present at the {i} and {j} ({inputArray[i]} + {inputArray[j]}) = {sum}");
                    }
                }
            }
        }

        public static void FindTheSumPairComplexitynlogn(int[] inputArray, int sum)
        {
            Array.Sort(inputArray);
            int low = 0, high = inputArray.Length - 1;
            while (low < high)
            {
                if (inputArray[low] + inputArray[high] == sum)
                {
                    Console.WriteLine($"The sum is present at the {low} and {high} ({inputArray[low]} + {inputArray[high]}) = {sum}");
                    return;
                }
                if (inputArray[low] + inputArray[high] < sum)
                {
                    low++;
                }
                else
                {
                    high++;
                }
            }
            Console.WriteLine($"The pair for sum = {sum} not available ");
        }

        public static void LinearFindSumPair(int[] inputArray, int sum)
        {
            Dictionary<int, int> mappedDictionary = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {

                if (mappedDictionary.ContainsKey(sum - inputArray[i]))
                {

                    // Console.WriteLine($"The pair is present {mappedDictionary.Keys.ElementAt(sum - inputArray[i])}  and {i}");
                    return;
                }
                mappedDictionary.Add(inputArray[i], i);
            }

        }
    }
}