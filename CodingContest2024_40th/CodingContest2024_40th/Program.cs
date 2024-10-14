using CodingContest2024_40th.CodingContestHelper;
using CodingContest2024_40th.Collections;

namespace CodingContest2024_40th;

public static class Program
{
    public static void Main(string[] args)
    {
        Master.Run();
        Master.Test();
    }
    
    public static List<string> Solution(List<string> input)
    {
        List<string> output = new List<string>();

        int sum = input.Sum(x => int.Parse(x));
        output.Add(sum.ToString());
        
        return output;
    }
}