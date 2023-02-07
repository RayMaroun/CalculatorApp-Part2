using CalculatorTests.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    [Collection("Calculator Collection")]
    public class DivisionTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;

        public DivisionTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(-6, 2, -3)]
        [InlineData(6, -2, -3)]
        public void Divide_DividingTwoNumbers_ReturnsCorrectQuotient(int numerator, int denominator, int expectedResult)
        {
            // Arrange
            var calculator = _calculatorFixture.Calculator;

            // Act
            var result = calculator.Divide(numerator, denominator);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
