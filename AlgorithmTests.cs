using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindPairofIntsThatEqualZero
{
    [TestFixture]
    public class AlgorithmTests
    {
        // Test 1
        [Test]
        public void ReturnsEmptyIntegerArray()
        {
            int[] expected = new int[0];

            int[] output = new Algorithm().ReturnEmptyIntegerArray();

            Assert.AreEqual(expected, output);
        }

        // Test 2
        [Test]
        public void GivenLengthOf4ReturnsArrayOfLength4()
        {
            int[] array = new int[4] { 0, 1, 2, 3 };

            int expected = array.Length;

            int output = new Algorithm().ReturnLengthOfStaticArray();

             Assert.AreEqual(expected, output);
        }

        // Test 3 
        // need to make a dynamic array, using a loop
        [Test]
        public void GivenLengthOf5ReturnsArrayOfLength5()
        {
            int[] array = new int[5] { 0, 1, 2, 3, 4 };

            int expected = array.Length;

            int size = 5;

            int output = new Algorithm().ReturnLengthOfDynamicArray(size);

            Assert.AreEqual(expected, output);
        }

        // Test 4
        // need to make 2 separate random arrays of a length > 99, and check that they are different
       /*
        [Test]
        public void Given2ArraysChecksThatBothAreRandomized()
        {

        }
        */

        /* Test 5
        [Test]
        public void GivenIntAsInputReturnsRandomlyGeneratedArrayOfLengthX()
        {
            int numOfIntsInArray = 4;

            int[] array = new Algorithm().GenerateArrayOfIntsFromNegative1000toPositive1000(numOfIntsInArray);

            int output = array.Length;
            int expected = 4;

            Assert.AreEqual(expected, output);
        }
        */
        

        /* Test 6
        [Test]
        public void GivenIntegerArrayReturnsFirstNumPairThatEqual0()
        {
            int[] sampleData = new int[4] { 800, 5, 3, -800 };

            int[] ouput = new int[2] { 800, -800 };

            int[] GivenArrayOfIntsReturnsFirstPairOfIntsThatEquals0

            Assert.AreEqual(expected, output);
        }
        */

        /* Test 6
         [Test]
         public void GivenIntegerArrayReturnsAllPairsThatEqualZero()
         {

         }
         */

    }
}
