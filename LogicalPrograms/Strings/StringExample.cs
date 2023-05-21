using System;
using System.Text;

namespace LogicalPrograms.Strings
{
    public class StringExample
    {
        private string _inputString;
        public StringBuilder OutputString = new StringBuilder();
        public StringExample(string inputString)
        {

            _inputString = inputString;
        }

        public void RemovingDuplicatesFromString()
        {
            if (!string.IsNullOrEmpty(_inputString))
            {
                var charArray = _inputString.ToCharArray();
                Array.Sort(charArray);
                if (charArray[0] != charArray[1])
                {
                    OutputString.Append(charArray[0]);
                }
                for (int i = 1; i < charArray.Length - 1; i++)
                {
                    if (charArray[i] != charArray[i + 1] && charArray[i] != charArray[i - 1])
                    {
                        OutputString.Append(charArray[i]);
                    }
                }
                if (charArray[charArray.Length - 2] != charArray[charArray.Length - 1])
                {
                    OutputString.Append(charArray[charArray.Length - 1]);
                }
            }
        }

        public void FrequencyOfACharecter()
        {
            if (!string.IsNullOrEmpty(_inputString))
            {
                var charArray = _inputString.ToCharArray();
                Array.Sort(charArray);
                var length = charArray.Length;
                for (int i = 0; i < length; i++)
                {
                    int count = 0;
                    int k = i;
                    for (int j =0; j < length; j++)
                    {
                        if (charArray[i] == charArray[j])
                        {
                            count++;
                            k++;
                        }
                    }
                    Console.WriteLine($"the charecter {charArray[i]} have repeated by {count}");
                    i = k-1;

                }
            }
        }
    }
}
