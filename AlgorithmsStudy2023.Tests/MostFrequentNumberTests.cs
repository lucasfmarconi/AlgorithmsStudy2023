namespace AlgorithmsStudy2023.Tests;
public class MostFrequentNumberTests
{
    [Theory]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 1, 3, 1, 3, 2, 1 }, 1)]
    [InlineData(new[] { 0, -1, 10, 10, -1, 10, -1, -1, -1, 1 }, -1)]
    [InlineData(new[] { 3, 3, 1, 3, 2, 1 }, 3)]
    public void Given_valid_input_should_return_expected_result(int[] integerArray, int expected)
    {
        var result = MostFrequentNumber.Solution(integerArray);
        Assert.Equal(expected, result);
    }
}
