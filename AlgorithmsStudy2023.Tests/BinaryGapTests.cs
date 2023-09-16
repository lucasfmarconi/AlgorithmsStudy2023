namespace AlgorithmsStudy2023.Tests;

public class BinaryGapTests
{
    [Theory]
    [InlineData(1041, 5)]
    [InlineData(9, 2)]
    [InlineData(529, 4)]
    [InlineData(20, 1)]
    [InlineData(15, 0)]
    [InlineData(32, 0)]
    [InlineData(0, 0)]
    [InlineData(int.MaxValue, 0)]
    [InlineData(1, 0)]
    public void Given_valid_input_should_return_expected_result(int n, int expected)
    {
        var result = BinaryGap.Solution(n);
        Assert.Equal(expected, result);
    }
}