namespace AlgorithmsStudy2023.Tests;
public class NthElementTests
{
    [Theory]
    [InlineData(new[] { 7, 6, 5, 4, 3, 2, 1 }, 3, 3)]
    [InlineData(new[] { 7, 6, 5, 4, 3, 2, 1 }, 1, 1)]
    [InlineData(new[] { 7, 6, 5, 4, 3, 2, 1 }, 5, 5)]
    [InlineData(new[] { 7, 6, 5, 4, 3, 2, 1 }, 7, 7)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, 3)]
    [InlineData(new[] { 1, 2, 3, 4 }, 4, 1)]
    [InlineData(new[] { 1, 2, 3, 4 }, 5, 0)]
    public void Given_valid_input_should_return_expected_result(int[] headIntegerArray, int value, int expectedReturn)
    {
        var countFromEnd = headIntegerArray.Length - 1;
        var initialValue = headIntegerArray[countFromEnd..][0];
        var current = new Node(initialValue, null);
        for (var i = headIntegerArray.Length - 2; i >= 0; i--)
        {
            var newNodeValue = headIntegerArray[i];
            current = new Node(newNodeValue, current);
        }
        //This logic above is to convert any array theory inline data to a Linked List
        var result = NthElement.ReturnNthValueFromEnd(current, value);
        Assert.Equal(expectedReturn, result);
    }
}
