namespace AlgorithmsStudy2023;

public class CommonSortedArrayElements
{
    public static int[] CommonElements(int[] integerArrayOne, int[] integerArrayTwo)
    {
        var commonElemetsArray = new List<int>();
        var indexArrayOne = 0;
        var indexArrayTwo = 0;

        while (indexArrayOne < integerArrayOne.Length && indexArrayTwo < integerArrayTwo.Length)
        {
            var elementInOne = integerArrayOne[indexArrayOne];
            var elementInTwo = integerArrayTwo[indexArrayTwo];
            if (elementInOne == elementInTwo)
            {
                commonElemetsArray.Add(elementInOne);
                indexArrayOne++;
                indexArrayTwo++;
                continue;
            }

            if (elementInOne > elementInTwo)
            {
                indexArrayTwo++;
                continue;
            }

            if (elementInOne < elementInTwo)
                indexArrayOne++;
        }

        return commonElemetsArray.ToArray();
    }
}
