using Xunit;
using CodingContest2024_40th.Collections;
using System.Collections.Generic;

namespace CodingContest2024_40th.Test.Collections
{
    public class IntExtensionsTests
    {
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
    }
}