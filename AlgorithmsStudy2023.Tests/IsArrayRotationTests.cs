namespace AlgorithmsStudy2023.Tests;
public class IsArrayRotationTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 4, 5, 6, 7, 1, 2, 3 }, true)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 4, 5, 6, 7, 1, 2 }, false)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 4, 5, 6, 7, 1, 2, 3 }, false)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 8, 7, 6, 5, 4, 3, 2, 1 }, false)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 6, 7, 8, 5, 4, 1, 2, 3 }, false)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 6, 7, 8, 1, 2, 3, 4, 5 }, true)]
    [InlineData(new[] { 6, 7, 8, 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, true)]
    public void Given_valid_input_should_return_expected_result(int[] integerArrayOne, int[] integerArrayTwo, bool isArrayRotation)
    {
        var result = IsArrayRotation.IsArrayRotationSolution(integerArrayOne, integerArrayTwo);
        Assert.Equal(isArrayRotation, result);
    }
}
