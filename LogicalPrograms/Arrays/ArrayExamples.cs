using System;

namespace LogicalPrograms.Arrays
{
    public class ArrayExamples
    {
        private int[] _intergerArray;

        public ArrayExamples(int size)
        {
            _intergerArray = new int[size];
        }

        public void PrintArray()
        {
            Console.WriteLine(new string('-', 10));
            if (_intergerArray.Length != 0)
                foreach (var item in _intergerArray)
                {
                    Console.Write($"[{item}]\t");
                }
        }

        public void AcceptInputForSingleDimensionArray()
        {
            if (_intergerArray != null)
                for (int i = 0; i < _intergerArray.Length; i++)
                {
                    Console.WriteLine($"Please Enter the number {i + 1} till {_intergerArray.Length}");
                    _intergerArray[i] = int.Parse(Console.ReadLine());
                }
        }

        public void PrintMaximumElementInArray()
        {
            if (_intergerArray.Length != 0)
            {
                int maxNumber = _intergerArray[0];
                for (int i = 0; i < _intergerArray.Length; i++)
                {
                    if (maxNumber <= _intergerArray[i])
                    {
                        maxNumber = _intergerArray[i];
                    }
                }

                Console.WriteLine($"{new string('-', 10)} ");

                Console.WriteLine($"Maximum number is {maxNumber}");
            }
        }

        public void SortArray()
        {
            if (_intergerArray.Length != 0)
            {
                for (int i = 0; i < _intergerArray.Length; i++)
                {
                    for (int j = 0; j < _intergerArray.Length - 1; j++)
                    {
                        if (_intergerArray[j] > _intergerArray[j + 1])
                        {
                            int temp = _intergerArray[j];
                            _intergerArray[j] = _intergerArray[j + 1];
                            _intergerArray[j + 1] = temp;
                        }

                    }
                }

                Console.WriteLine($"Your Sorted Array : ");
                foreach (var item in _intergerArray)
                {
                    Console.Write(item);
                }
            }
        }

        public int BinarySearch(int key)
        {
            if (_intergerArray.Length != 0)
            {
                SortArray();

                int low = 0, heigh = _intergerArray.Length - 1;
                while (low < heigh)
                {
                    int mid = (heigh + low) / 2;
                    if (_intergerArray[mid] == key)
                        return mid;
                    if (_intergerArray[mid] < key)
                        low = mid + 1;
                    else
                        heigh = mid - 1;

                }
            }
            return -1;
        }

        public void DifferenceBetweenTheArray()
        {
            Console.WriteLine();
            if (_intergerArray.Length != 0)
            {
                for (int i = 0; i < _intergerArray.Length; i++)
                {
                    var nextIndex = (i + 1) == _intergerArray.Length ? 0 : (i + 1);
                    Console.WriteLine(_intergerArray[nextIndex] - _intergerArray[i]);
                }
            }
        }
        public void RemovingTheDuplicatesFromArray()
        {
            if (_intergerArray.Length != 0)
            {
                var size = _intergerArray.Length;
                for (int i = 0; i < size; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (_intergerArray[j] == _intergerArray[i])
                        {
                            _intergerArray[j] = _intergerArray[size - 1];
                            size--;
                            j--;
                        }

                    }
                }

                for (int i = 0; i < _intergerArray.Length; i++)

                {
                    Console.WriteLine(_intergerArray[i]);
                }
            }
        }

    }
}