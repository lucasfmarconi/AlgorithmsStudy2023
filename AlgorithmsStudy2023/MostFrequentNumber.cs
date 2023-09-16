namespace AlgorithmsStudy2023;

//BIG O - O(n)
public static class MostFrequentNumber
{
    public static int Solution(int[] integerArray)
    {
        int result = default;
        int maxCount = default;
        
        for (var i = 0; i < integerArray.Length; i++)
        {
            var keyPairOccurrencesDictionary = new Dictionary<int, int>();
            var iterationInteger = integerArray[i];
            var occurrences = 0;
            for (var j = 0; j < integerArray.Length; j++)
            {
                var internalIterationInteger = integerArray[j];
                if (iterationInteger == internalIterationInteger)
                    occurrences++;
            }

            keyPairOccurrencesDictionary[iterationInteger] = occurrences;

            if (occurrences <= maxCount) continue;
            
            maxCount = occurrences;
            result = iterationInteger;
        }

        return result;
    }
}
