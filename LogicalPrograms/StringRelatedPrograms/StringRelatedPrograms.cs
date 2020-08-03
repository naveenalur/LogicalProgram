using System;

namespace LogicalPrograms.StringRelatedPrograms
{
    public class StringRelatedPrograms
    {
        private static StringRelatedPrograms _instance;

        public static StringRelatedPrograms Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StringRelatedPrograms();
                }
                return _instance;
            }
        }

        public void DisplayString(string inputString)
        {
            Console.WriteLine(inputString);
        }

        public void ToCharArrayS(string input)
        {
            var array = input.ToCharArray();
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }
        }

        public void ReverseInputString(string inputString)
        {
            var inputCharecterArray = inputString.ToString();
            string str = string.Empty;
            for (int i = inputCharecterArray.Length - 1; i >= 0; i--)
            {
                str += inputCharecterArray[i];
            }
            Console.WriteLine(str);
        }

        public void ReverserInputStringEachWord(string inputString)
        {
            char[] inputToCharArray = inputString.ToCharArray();
            string str = string.Empty;
            for (int i = 0; i < inputToCharArray.Length; i++)
            {
                int k = i;
                while (i < inputToCharArray.Length && inputToCharArray[i] != ' ')
                    i++;
                int j = i - 1;
                while (j >= k)
                {
                    str += inputToCharArray[j];
                    j--;
                }
                if (i < inputToCharArray.Length)
                {
                    str += inputString[i];
                }
            }
            Console.WriteLine(str);
        }

        public void ReverseWholeSentnceWithWordCurrect(string inputString)
        {
            char[] inputToCharArray = inputString.ToCharArray();
            string str = string.Empty;
            for (int i = inputToCharArray.Length - 1; i > 0; i--)
            {
                int k = i;
                while (i >= 0 && inputToCharArray[i] != ' ')
                {
                    i--;
                }
                int j = i + 1;
                while (j <= k)
                {
                    str += inputToCharArray[j];
                    j++;
                }
                if (i >= 0)
                {
                    str += inputString[i];
                }
            }
            Console.WriteLine(str);
        }


    }
}