namespace AlgorithmsStudy2023;

public class BinaryGap
{
    public static int Solution(int n)
    {
        var binaryRepresentation = Convert.ToString(n, 2);
        var binGapArray = binaryRepresentation.Split("1");
        return binGapArray.Length < 3 ? 0 : RoamArray(binGapArray);
    }

    private static int RoamArray(string[] binGapArray)
    {
        var maxSize = 0;
        const int skipArrayInit = 1;
        var skipArrayEnd = binGapArray.Length - 1;
        
        binGapArray = binGapArray[skipArrayInit..skipArrayEnd];
        for (var index = 0; index < binGapArray.Length; index++)
        //for (var index = skipArrayInit; index < skipArrayEnd; index++)
        {
            var binGap = binGapArray[index];
            var binGapStringLength = binGap.Length;
            
            maxSize = binGapStringLength > maxSize ? binGapStringLength : maxSize;
        }
        return maxSize;
    }
}
