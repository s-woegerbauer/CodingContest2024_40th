namespace CodingContest2024_40th.CodingContestHelper;

public class Parser(string[] input)
{
    public int[] ParseToInt()
    {
        int[] result = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = int.Parse(input[i]);
        }

        return result;
    }

    public double[] ParseToDouble()
    {
        double[] result = new double[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = double.Parse(input[i]);
        }

        return result;
    }
}