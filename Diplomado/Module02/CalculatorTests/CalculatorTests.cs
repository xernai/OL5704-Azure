using System;
using Utilities;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        // TDD: Test Driven Development
        // Frameworks, xUnit, MSTest, NUnit
        // Red, Green, Refactor
        // Moq que te simula que te conectas a la base de datos
        // Sonar

        [Fact]
        public void Divide_2By2_Returns1()
        {
            // Prepare  -> Arrange
            // Ejecutar -> Act
            // Evaluar  *> Assert
            Calculator calculator = new Calculator();
            int result = calculator.Divide(2, 2);

            Assert.Equal(1, result); // Se compara el valor esperado contra el valor actual
        }
    }
}
