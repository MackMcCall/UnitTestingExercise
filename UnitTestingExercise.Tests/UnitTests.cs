using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-4, 20, 4, 20)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(2, 2, 2, 6)]
        [InlineData(-2, -2, -2, -6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act
            int actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 10, 10)]
        [InlineData(1, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -10, 5)]
        [InlineData(5, -10, 15)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2, 2, 4)]
        [InlineData(9, 0, 0)]
        [InlineData(-2, 2, -4)]
        [InlineData(-3, -3, 9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 10, 2)]
        [InlineData(20, 2, 10)]
        [InlineData(5, -1, -5)]
        [InlineData(-10, -5, 2)]
        [InlineData(12, 1, 12)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int acatual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, acatual);
        }

    }
}
