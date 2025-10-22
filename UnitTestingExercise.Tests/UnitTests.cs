using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 5, 6, 15)]
        [InlineData(1, 2, 3, 6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);    

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);    
        }

        [Theory]
        [InlineData(5,3, 2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            var actual = calculator.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 5,15)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            var calculator = new Calculator();
            var actual = calculator.Multiply(num1, num2);
            Assert.Equal(expected, actual);

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(4,2,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            var actual = calculator.Divide(num1, num2);
            Assert.Equal(expected, actual);

            //Act

            //Assert

        }

    }
}
