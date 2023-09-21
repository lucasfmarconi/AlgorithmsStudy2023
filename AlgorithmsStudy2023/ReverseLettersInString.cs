namespace AlgorithmsStudy2023;
public static class ReverseLettersInString
{
    public static string ReverseLettersInStringSolution(string originalString)
    {
        var originalStringArray = originalString.ToCharArray();
        var pointerOnTheLeft = 0;
        var pointerOnTheRight = originalStringArray.Length - 1;
        var reversedStringArray = new char[originalStringArray.Length];
        while (pointerOnTheLeft < originalStringArray.Length)
        {
            var currentCharValueOnTheLeft = originalStringArray[pointerOnTheLeft];
            if (char.IsLetter(currentCharValueOnTheLeft))
            {
                var currentCharValueOnTheRight = originalStringArray[pointerOnTheRight];
                if (char.IsLetter(currentCharValueOnTheRight))
                {
                    reversedStringArray[pointerOnTheLeft] = currentCharValueOnTheRight;
                    reversedStringArray[pointerOnTheRight] = currentCharValueOnTheLeft;
                    pointerOnTheLeft++;
                    pointerOnTheRight--;
                    continue;
                }
                pointerOnTheRight--;
                reversedStringArray[pointerOnTheRight] = currentCharValueOnTheRight;
                continue;
            }

            reversedStringArray[pointerOnTheLeft] = currentCharValueOnTheLeft;
            pointerOnTheLeft++;
        }

        return string.Concat(reversedStringArray);
    }
}
