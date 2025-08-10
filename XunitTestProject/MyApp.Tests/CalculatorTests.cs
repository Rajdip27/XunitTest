namespace XunitTestProject.MyApp.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, -1, -2)]
    [InlineData(0, 5, 5)]
    public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
    {
        var calc = new Calculator();
        var result = calc.Add(a, b);
        Assert.Equal(expected, result);
    }
}
