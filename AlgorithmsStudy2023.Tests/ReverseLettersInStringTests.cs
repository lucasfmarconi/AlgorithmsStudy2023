using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy2023.Tests;
public class ReverseLettersInStringTests
{
    [Theory]
    [InlineData("ab-cd", "dc-ba")]
    [InlineData("a-bC-dEf=ghIj!!", "j-Ih-gfE=dCba!!")]
    public void Given_valid_input_should_return_expected_result(string original, string expectedResult)
    {
        var result = ReverseLettersInString.ReverseLettersInStringSolution(original);
        Assert.Equal(expectedResult, result);
    }
}
