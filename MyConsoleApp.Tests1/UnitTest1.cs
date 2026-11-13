namespace MyConsoleApp.Tests1
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(10, 20);

            // Assert
            Assert.Equal(30, result);
        }
    }
}
