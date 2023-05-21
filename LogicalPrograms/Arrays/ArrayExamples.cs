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

                Console.WriteLine($"{new string('-', 10)}\n");

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

        public void RemoveDuplicateUsingSort()
        {
            Array.Sort(_intergerArray);
            PrintArray();
            if(_intergerArray[0]!=_intergerArray[1])
            {
                Console.WriteLine(_intergerArray[0]);
            }
                for (int i = 1; i < _intergerArray.Length-1; i++)
            {
                if (_intergerArray[i] != _intergerArray[i+1] && _intergerArray[i] != _intergerArray[i - 1])
                {
                    Console.WriteLine(_intergerArray[i]);
                }
            }

            if(_intergerArray[_intergerArray.Length -2] != _intergerArray[_intergerArray.Length - 1])
                Console.WriteLine(_intergerArray[_intergerArray.Length - 1]);
        }

        public void BubbleSort()
        {
            for (int i = 0; i < _intergerArray.Length; i++)
            {
                for (int j = i+1; j < _intergerArray.Length-1; j++)
                {
                    if (_intergerArray[i] > _intergerArray[j]) 
                    {
                        int temp = _intergerArray[i];
                        _intergerArray[i] = _intergerArray[j];
                        _intergerArray[j] = temp;
                    }

                }
            }
        }

        public void QuickSortAlgo()
        {
            int low = 0;
            int high = _intergerArray.Length-1;
            QuickSort(_intergerArray,low,high);

        }
        private void QuickSort(int[] arr,int low,int high)
        {
            if (low < high)
            {
                int partiTionKey=Partion(arr,low,high);
                QuickSort(arr,low,partiTionKey-1);
                QuickSort(arr, partiTionKey+1,high);
            }

        }

        private int Partion(int[] arr,int low,int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr,i,j);
                }
            }
            Swap(arr,i+1,high);
            return i + 1;
        }

        private void Swap(int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}