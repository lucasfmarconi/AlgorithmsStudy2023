namespace AlgorithmsStudy2023.Tests;
public class CommonSortedArrayElementsTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 4, 6, 7, 9 }, new[] { 1, 2, 4, 5, 9, 10 }, new[] { 1, 4, 9 })]
    [InlineData(new[] { 1, 2, 9, 10, 11, 12 }, new[] { 0, 1, 2, 3, 4, 5, 8, 9, 10, 12, 14, 15 }, new[] { 1,2,9,10,12 })]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5, 8, 9, 10, 12, 14, 15 }, new[] { 1, 2, 9, 10, 11, 12 }, new[] { 1,2,9,10,12 })]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5 }, new[] {6, 7, 8, 9, 10, 11}, new int[]{})]
    public void Given_valid_input_should_return_expected_result(int[] integerArrayOne, int[] integerArrayTwo, int[] integerArrayExpected)
    {
        var result = CommonSortedArrayElements.CommonElements(integerArrayOne, integerArrayTwo);
        Assert.Equal(integerArrayExpected, result);
    }
}
