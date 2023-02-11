
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    [Collection("Calculator Unit Tests Collection")]
    public class DivisionTests
    {
        private readonly CalculatorUnittestsFixture _calculatorFixture;

        public DivisionTests(CalculatorUnittestsFixture calculatorFixture)
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
