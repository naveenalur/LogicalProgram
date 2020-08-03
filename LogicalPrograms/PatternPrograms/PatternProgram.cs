using System;

namespace LogicalPrograms.PatternPrograms
{
    public class PatternProgram
    {
        private int _number;

        public PatternProgram(int number)
        {
            _number = number;
        }

        public void PrintTrianglePattern()
        {
            for (int i = 0; i < _number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void PrintInvertedTrianglePattern()
        {
            for (int i = _number; i > 0; i -= 2)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void PrintPyramid()
        {
            int i, j, n = _number;
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}