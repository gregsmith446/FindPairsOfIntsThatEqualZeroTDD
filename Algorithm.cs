using System;

namespace FindPairofIntsThatEqualZero
{
    class Algorithm
    {
        public int[] ReturnEmptyIntegerArray()
        {
            int[] emptyArray = new int[0];

            return emptyArray;
        }

        public int ReturnLengthOfStaticArray()
        {
            int[] emptyArray = new int[4] { 0, 1, 2, 4 };

            return emptyArray.Length;
        }

        public int ReturnLengthOfDynamicArray(int length)
        {
            int[] dynamicArr = new int[length];

            for (int i = 0; i < length; i++)
            {
                dynamicArr[i] = 1;
            }

            return dynamicArr.Length;
        }

        public bool ReturnsTrueIfBothArrayContentsAreDifferent(int sizeOfArrayToCreate)
        {
            int[] arr1 = new int[sizeOfArrayToCreate];
            int[] arr2 = new int[sizeOfArrayToCreate];

            Random random = new Random();

            for (int i = 0; i < sizeOfArrayToCreate; i++)
            {
                int temp = random.Next(-1000, 1001);
                arr1[i] = temp;
            }

            for (int i = 0; i < sizeOfArrayToCreate; i++)
            {
                int temp = random.Next(-1000, 1001);
                arr2[i] = temp;
            }

            if (string.Join(",", arr1) == string.Join(",", arr2))
            {
                Console.WriteLine(string.Join(",", arr1));
                Console.WriteLine(string.Join(",", arr2));
                return false;
            }
            else
            {
                Console.WriteLine(string.Join(",", arr1));
                Console.WriteLine(string.Join(",", arr2));
                return true;
            }
        }

        public int[] GivenArrayOfIntsReturnsFirstPairOfIntsThatEqualsZero(int[] arrayOfInts)
        {
            int[] pair = new int[2] { 0, 0 };

            int num = 0;

            while (num < arrayOfInts.Length - 1)
            {
                for (int i = arrayOfInts.Length - 1; i > 1; i--)
                {
                    int arrayIndex = 0;

                    if (Math.Abs(arrayOfInts[num]) - Math.Abs(arrayOfInts[i]) == 0)
                    {
                        pair[arrayIndex] = arrayOfInts[num];
                        arrayIndex++;
                        pair[arrayIndex] = arrayOfInts[i];
                    }
                    num++;
                }
            }
            return pair;
        }

        public int ReturnsNumberOfPairsThatEqualZero(int[] arrayOfInts)
        {
            int num = 0;

            int counter = 0;

            while (num < arrayOfInts.Length - 1)
            {
                for (int i = arrayOfInts.Length - 1; i > 1; i--)
                {
                    if (Math.Abs(arrayOfInts[num]) - Math.Abs(arrayOfInts[i]) == 0)
                    {
                        // Console.WriteLine(arrayOfInts[num]);
                        // Console.WriteLine(arrayOfInts[i]);

                        counter++;
                        num++;
                    }
                    Console.WriteLine(num);
                    Console.WriteLine(i);
                }
                num++;
            }
            return counter;
        }
    }     
}
