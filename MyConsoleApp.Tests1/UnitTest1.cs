using GitHubCI_Demo;
using Xunit;

namespace MyConsoleApp.Tests1
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(15, calculator.Add(10, 5));
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(5, calculator.Subtract(10, 5));
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(50, calculator.Multiply(10, 5));
        }

        [Fact]
        public void Divide_ReturnsCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(2, calculator.Divide(10, 5));
        }
    }

}