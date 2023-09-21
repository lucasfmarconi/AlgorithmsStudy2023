namespace AlgorithmsStudy2023;

//A past Turing.com problem
public static class BaseBallGame
{
    public static int CalPoints(string[] ops)
    {
        int previousScoreIndex = 0, lastScoreIndex = 0;
        var scoreRecords = new List<int>();
        for (var i = 0; i < ops.Length; i++)
        {
            if (int.TryParse(ops[i], out var opScore))
            {
                previousScoreIndex = lastScoreIndex;
                lastScoreIndex = i;
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
                    var doubleScore = 2 * int.Parse(ops[lastScoreIndex]);
                    scoreRecords.Add(doubleScore);
                    break;
                case "C":
                    lastScoreIndex = previousScoreIndex;
                    var maxIndex = scoreRecords.Count - 1;
                    scoreRecords.RemoveRange(maxIndex, 1);
                    break;
            }
        }
        return scoreRecords.Sum();
    }
}
