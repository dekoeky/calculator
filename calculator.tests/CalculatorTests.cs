namespace calculator.tests;

/// <summary>
/// <see cref="Calculator"/> related tests.
/// </summary>
[TestClass]
public sealed class CalculatorTests
{
    [TestMethod]
    public void Constructor()
    {
        // Act
        var calculator = new Calculator();

        // Assert
        Assert.IsNotNull(calculator);
    }

    [TestMethod]
    public void ImplementsICalculator()
    {
        // Act
        var calculator = new Calculator();

        // Assert
        Assert.IsInstanceOfType<ICalculator>(calculator);
    }

    [TestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(-5, -10, -15)]
    public void Add(double a, double b, double expected, double accuracy = 0)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result, accuracy);
    }

    [TestMethod]
    [DataRow(1, 2, -1)]
    [DataRow(-5, -10, +5)]
    public void Subtract(double a, double b, double expected, double accuracy = 0)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(a, b);

        // Assert
        Assert.AreEqual(expected, result, accuracy);
    }

    [TestMethod]
    [DataRow(1, 2, 2)]
    [DataRow(-5, -10, +50)]
    public void Multiply(double a, double b, double expected, double accuracy = 0)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Multiply(a, b);

        // Assert
        Assert.AreEqual(expected, result, accuracy);
    }

    [TestMethod]
    [DataRow(1, 2, 0.5)]
    [DataRow(-5, -10, +0.5)]
    public void Divide(double a, double b, double expected, double accuracy = 0)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Divide(a, b);

        // Assert
        Assert.AreEqual(expected, result, accuracy);
    }
}
