namespace AlgorithmsStudy2023;
public static class TwoIntegerMultiply20
{
    //1, 2, 3, 4, 5, 6
    public static int[] Solution(int[] integerArray)
    {
        //TODO: Implement an more optimal solution than this
        for (var i = 0; i < integerArray.Length; i++)
        {
            if (integerArray[i] > 20 || integerArray[i] <= 0)
                continue;
            
            var multiplier = integerArray[i];
            
            for (var j = i; j < integerArray.Length; j++)
            {
                if (multiplier * j == 20)
                    return new[] { multiplier, j };
            }
        }
        //Input arrays must be valid in this case (like 4,5 or 20,1 or 2,10)
        return integerArray;
    }
}
