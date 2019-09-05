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

        /*
        public int[] GenerateArrayOfIntsFromNegative1000toPositive1000(int sizeOfArrayToCreate)
        {
            int[] testData = new int[sizeOfArrayToCreate];

            Random random = new Random();

            for (int i = 0; i < sizeOfArrayToCreate; i++)
            {
                int temp = random.Next(-1000, 1001);
                testData[i] = temp;
            }

            return testData;
        }
        */

        /*
        public int[] GivenArrayOfIntsReturnsFirstPairOfIntsThatEquals0(int[] arrayOfInts)
        {
            int[] pair = new int[2];

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] - arrayOfInts[i + 1] == 0 || arrayOfInts[i] + arrayOfInts[i + 1] == 0)
                {

                }
            }
            return pair;
        }
        */

        /*
        public int GivenArrayOfIntsReturnsNumberOfPairsThatEqualZero()
        {
            return 1;
        }
        */

    }
        
       
}
