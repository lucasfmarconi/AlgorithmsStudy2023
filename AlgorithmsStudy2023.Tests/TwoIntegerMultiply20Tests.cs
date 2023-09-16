namespace AlgorithmsStudy2023.Tests;

public class TwoIntegerMultiply20Tests
{
    [Theory]
    [InlineData(new[]{ 2, 10 })]
    public void Given_valid_input_should_return_expected_result(int[] integerArray)
    {
        var result = TwoIntegerMultiply20.Solution(integerArray);
        Assert.Equal(20, result[0] * result[1]);
    }
}
