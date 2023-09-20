namespace AlgorithmsStudy2023;
public static class IsArrayRotation
{
    //BIG O - O(n) or O(2n)
    public static bool IsArrayRotationSolution(int[] arrayA, int[] arrayB)
    {
        if (arrayA.Length != arrayB.Length)
            return false;

        var lockPointer = -1;
        var valueInA = arrayA[0];

        for (var i = 0; i < arrayB.Length; i++)
        {
            var valueInB = arrayB[i];
            if (valueInA != valueInB) continue;

            lockPointer = i;
            break;
        }

        if (lockPointer == -1)
            return false;

        for (var i = 0; i < arrayA.Length; i++)
        {
            var j = (lockPointer + i) % arrayA.Length;
            //e.g. 3 % 8 = 3 (remainder of a division) Isn't it hacky? :)
            
            if (arrayA[i] != arrayB[j])
                return false;
        }

        return true;
    }
}
