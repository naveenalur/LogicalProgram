
using LogicalPrograms.Algorithm;
using LogicalPrograms.Arrays;
using LogicalPrograms.NumaricPrograms;
using LogicalPrograms.PatternPrograms;
using System;

namespace LogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //  Console.WriteLine("Please Enter the Number ");

            // var number = int.Parse(Console.ReadLine());

            //PatternProgram patternProgram = new PatternProgram(number);
            //patternProgram.PrintTrianglePattern();

            //Console.WriteLine(new string('-', 100));
            //patternProgram.PrintInvertedTrianglePattern();
            //Console.WriteLine(new string('-', 100));
            //patternProgram.PrintPyramid();
            // Console.WriteLine(new string('f', 100));

            //NumberRelatedPrograms.Instance.PrintFibonacciNumber(number);
            // Console.WriteLine(new string(';', 10));
            //  NumberRelatedPrograms.Instance.CheckPolindrome(number);


            Console.WriteLine(new String('_', 10));
            //Console.WriteLine(NumberRelatedPrograms.Instance.Factorial(number));


            //string inputString = "Naveen is getting Job in Google";
            //StringRelatedPrograms.StringRelatedPrograms.Instance.ToCharArrayS(inputStrig);
            //StringRelatedPrograms.StringRelatedPrograms.Instance.ReverserInputStringEachWord(inputString);
            //Console.WriteLine(new string('-', 15));
            //StringRelatedPrograms.StringRelatedPrograms.Instance.ReverseWholeSentnceWithWordCurrect(inputString);


            //var arraySample = new ArrayExamples(5);
            //arraySample.AcceptInputForSingleDimensionArray();
            //arraySample.PrintArray();
            ////arraySample.PrintMaximumElementInArray();
            ////var index = arraySample.BinarySearch(5);
            ////if (index != -1) Console.WriteLine($"The element is found at the {index}");
            //// arraySample.DifferenceBetweenTheArray();
            //arraySample.RemovingTheDuplicatesFromArray();
            // FindingPairWithGivenSum.FindTheSumPair(new int[] { 8, 7, 2, 5, 3, 1 }, 10);
            // FindingPairWithGivenSum.FindTheSumPairComplexitynlogn(new int[] { 8, 7, 2, 5, 3, 1 }, 10);
            FindingPairWithGivenSum.LinearFindSumPair(new int[] { 8, 7, 2, 5, 3, 1 }, 10);

            Console.ReadLine();



        }
    }
}
