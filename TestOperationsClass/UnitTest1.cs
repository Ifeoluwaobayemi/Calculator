using Xunit;
using Calculator.Core;
using Calculator.Core.Logic;

namespace TestOperationsClass
{
    public class OperationsTest
    {
        private readonly Operations _operations;
        public OperationsTest()
        {
            _operations = new Operations();
        }
        [Fact]
        public void Add_ValidNumbers_ReturnsSumAsString()
        {
            //Arrange
        
            string firstNumber = "5";
            string secondNumber = "5";
            string expectedResult = "10";

            //Act
            string result = _operations.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Add_InvalidFirstNumber_ReturnInvalidNumberMessage() 
        {
            //Arrange

            string firstNumber = "Invalid";
            string secondNumber = "5";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Add_InvalidSecondNumber_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "5";
            string secondNumber = "Invalid";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Add_BothNumbersInvalid_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "Invalid";
            string secondNumber = "Invalid";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        public void Subtract_ValidNumbers_ReturnsSumAsString()
        {
            //Arrange

            string firstNumber = "15";
            string secondNumber = "5";
            string expectedResult = "10";

            //Act
            string result = _operations.Subtract(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtract_InvalidFirstNumber_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "Invalid";
            string secondNumber = "5";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Subtract(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Subtract_InvalidSecondNumber_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "15";
            string secondNumber = "Invalid";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Subtract(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Subtract_BothNumbersInvalid_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "Invalid";
            string secondNumber = "Invalid";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Subtract(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        public void Multiply_ValidNumbers_ReturnsSumAsString()
        {
            //Arrange

            string firstNumber = "20";
            string secondNumber = "5";
            string expectedResult = "100";

            //Act
            string result = _operations.Multiply(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_InvalidFirstNumber_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "Invalid";
            string secondNumber = "5";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Multiply(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Multiply_InvalidSecondNumber_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "20";
            string secondNumber = "Invalid";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Multiply(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Multiply_BothNumbersInvalid_ReturnInvalidNumberMessage()
        {
            //Arrange

            string firstNumber = "Invalid";
            string secondNumber = "Invalid";
            string expectedErrorMessage = "Invalid number";

            //Act
            string result = _operations.Multiply(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Divide_ValidNumbers_ReturnsQuotientAsString()
        {
            // Arrange
            string firstNumber = "10";
            string secondNumber = "2";
            string expectedResult = "5";

            // Act
            string result = _operations.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void Divide_InvalidFirstNumber_ReturnsInvalidNumberMessage()
        {
            // Arrange
            string firstNumber = "invalid";
            string secondNumber = "5";
            string expectedErrorMessage = "Invalid number";

            // Act
            string result = _operations.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Divide_InvalidSecondNumber_ReturnsInvalidNumberMessage()
        {
            // Arrange
            string firstNumber = "10";
            string secondNumber = "invalid";
            string expectedErrorMessage = "Invalid number";

            // Act
            string result = _operations.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Divide_BothNumbersInvalid_ReturnsInvalidNumberMessage()
        {
            // Arrange
            string firstNumber = "invalid";
            string secondNumber = "invalid";
            string expectedErrorMessage = "Invalid number";

            // Act
            string result = _operations.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        [Fact]
        public void Divide_ByZeroMessage()
        {
            //Arrange
            string firstNumber = "5";
            string secondNumber = "0";
            string expectedErrorMessage = "Cannot be divided by 0";
            //Act
            string result = _operations.Divide(firstNumber,secondNumber);
            //Assert
            Assert.Equal(expectedErrorMessage, result);
        }

        

    }
}