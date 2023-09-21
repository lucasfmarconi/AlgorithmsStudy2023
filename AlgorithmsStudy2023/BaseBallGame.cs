namespace AlgorithmsStudy2023;

//A past Turing.com problem
public static class BaseBallGame
{
    public static int CalPoints(string[] ops)
    {
        var scoreRecords = new List<int>();
        for (var i = 0; i < ops.Length; i++)
        {
            if (int.TryParse(ops[i], out var opScore))
            {
                scoreRecords.Add(opScore);
                continue;
            }

            switch (ops[i])
            {
                case "+":
                    var previousScoresSum = scoreRecords[^1] + scoreRecords[^2];
                    scoreRecords.Add(previousScoresSum);
                    break;
                case "D":
                    var doubleScore = 2 * scoreRecords[^1];
                    scoreRecords.Add(doubleScore);
                    break;
                case "C":
                    var maxIndex = scoreRecords.Count - 1;
                    scoreRecords.RemoveRange(maxIndex, 1);
                    break;
            }
        }
        return scoreRecords.Sum();
    }
}
