using Xunit;
using CodingContest2024_40th.Collections;

namespace CodingContest2024_40th.Test.Collections
{
    public class StringExtenstionTests
    {
        [Fact]
        public void Reverse_ShouldReverseString()
        {
            string input = "hello";
            string expected = "olleh";
            string result = input.Reverse();
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Remove_ShouldRemoveSubstring()
        {
            string input = "hello world";
            string remove = "world";
            string expected = "hello ";
            string result = input.Remove(remove);
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurence_ShouldCountOccurrences()
        {
            string input = "hello hello";
            string occurence = "hello";
            int expected = 2;
            int result = input.CountOccurence(occurence);
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void LengthInMinMax_ShouldReturnTrueIfLengthInRange()
        {
            string input = "hello";
            bool result = input.LengthInMinMax(3, 10);
            Xunit.Assert.True(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnTrueForNumericString()
        {
            string input = "12345";
            bool result = input.IsNumeric();
            Xunit.Assert.True(result);
        }

        [Fact]
        public void ToDigits_ShouldReturnArrayOfDigits()
        {
            int input = 12345;
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] result = input.ToDigits();
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void DigitSum_ShouldReturnSumOfDigits()
        {
            int input = 12345;
            int expected = 15;
            int result = input.DigitSum();
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void DigitProduct_ShouldReturnProductOfDigits()
        {
            int input = 123;
            int expected = 6;
            int result = input.DigitProduct();
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void DigitCount_ShouldReturnNumberOfDigits()
        {
            int input = 12345;
            int expected = 5;
            int result = input.DigitCount();
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void DigitAverage_ShouldReturnAverageOfDigits()
        {
            int input = 12345;
            double expected = 3.0;
            double result = input.DigitAverage();
            Xunit.Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void AddOrUpdate_ShouldAddOrUpdateDictionary()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.AddOrUpdate("key1", 1);
            dictionary.AddOrUpdate("key1", 2);
            Xunit.Assert.Equal(2, dictionary["key1"]);
        }
    }
}