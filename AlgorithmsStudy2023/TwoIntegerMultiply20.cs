namespace AlgorithmsStudy2023;
public static class TwoIntegerMultiply20
{
    public static int[] Solution(int[] integerArray)
    {
        //TODO: Implement an more optimal solution than this
        for (var i = 0; i < integerArray.Length; i++)
        {
            var multiplier = integerArray[i];

            if (multiplier > 20)
                continue;
            
            for (var j = i; j < integerArray.Length; j++)
            {
                var secondMultiplier = integerArray[j];
                if (multiplier * secondMultiplier == 20)
                    return new[] { multiplier, secondMultiplier };
            }
        }
        //Input arrays must be valid in this case (like 4,5 or 20,1 or 2,10)
        return integerArray;
    }
}
