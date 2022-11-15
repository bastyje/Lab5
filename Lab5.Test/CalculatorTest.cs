using Xunit;
using Lab5.Lib;

namespace Lab5.Test;

public class CalculatorTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 0, -1)]
    [InlineData(5, -10, -5)]
    public void Sum_ShouldReturnSum(int x, int y, int expected)
    {
        // arrange
        var calculator = new Calculator();

        //act
        var sum = calculator.Sum(x, y);

        // assert
        Assert.Equal(sum, expected);
    }
}