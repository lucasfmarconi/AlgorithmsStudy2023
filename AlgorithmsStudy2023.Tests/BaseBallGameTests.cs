namespace AlgorithmsStudy2023.Tests;

public class BaseBallGameTests
{
    [Theory]
    [InlineData(new[] { "5", "2", "C", "D", "+" }, 30)]
    [InlineData(new[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]
    public void Given_valid_input_should_return_expected_result(string[] operationsArray, int expectedResult)
    {
        var result = BaseBallGame.CalPoints(operationsArray);
        Assert.Equal(expectedResult, result);
    }
}
