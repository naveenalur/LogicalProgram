using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms.NumaricPrograms
{
    public class NumberRelatedPrograms
    {
        private static NumberRelatedPrograms _instance;
        public static NumberRelatedPrograms Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NumberRelatedPrograms();
                }
                return _instance;
            }
        }

        public void PrintFibonacciNumber(int n)
        {
            int n1 = 0, n2 = 1;
            Console.Write($"{n1} {n2} ");
            for (int i = 0; i < n; i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        public void CheckPolindrome(int number)
        {
            int temp = number, sum = 0, reminder;
            while (number > 0)
            {
                reminder = number % 10;
                sum = (sum * 10) + reminder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"{sum} This number is the palindrome");
            }
            else
            {
                Console.WriteLine($"{sum} This number is not palindrome");
            }
        }
        public int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);

        }


    }
}
