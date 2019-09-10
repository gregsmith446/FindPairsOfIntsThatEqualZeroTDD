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
        // test that the array has randomly generated numbers from -1000 to 1000
        // do so by creating 2 randomly generated arrays and making sure they are random
        [Test]
        public void GivenIntRangeReturnsArrayOfRandomInts()
        {
            int size = 25;

            bool output = new Algorithm().ReturnsTrueIfBothArrayContentsAreDifferent(size);

            bool expected = true;

            Assert.AreEqual(expected, output);
        }
        
        // Test 5
        [Test]
        public void GivenStaticIntArrayReturnsFirstNumPairThatEqualZero()
        {
            int[] sampleData = new int[] { 800, 5, 3, -800 };

            int[] expected = new int[] { 800, -800 };
               
            int[] output = new Algorithm().GivenArrayOfIntsReturnsFirstPairOfIntsThatEqualsZero(sampleData);

            Assert.AreEqual(expected, output);
        }

         // Test 6
         [Test]
         public void ReturnsNumberOfPairsThatEqualZero()
         {
            int[] sampleData = new int[] { 800, 3, -800, 6, 6 };

            int expected = 2;

            int output = new Algorithm().ReturnsNumberOfPairsThatEqualZero(sampleData);

            Assert.AreEqual(expected, output);
         }

        // Test 7
        // Final Test, ReturnsNumberOfPairsThatEqualZero with real data
    }
}
