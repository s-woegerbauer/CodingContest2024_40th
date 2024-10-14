namespace CodingContest2024_40th.CodingContestHelper;

public static class InputOutput
{
    private static Reader? Reader { get; set; }
    private static Writer? Writer { get; set; }

    public static void Init(string fileName)
    {
        Reader = new Reader(Path.Combine(Directory.GetCurrentDirectory(), Settings.InputFilePath, fileName));
        Writer = new Writer(Path.Combine(Directory.GetCurrentDirectory(), Settings.OutputFilePath, fileName));
    }

    public static List<string> ReadInput()
    {
        using (Reader)
        {
            return Reader!.Read().ToList();
        }
    }

    public static void WriteOutput(List<string> output)
    {
        using (Writer)
        {
            Writer!.Add(string.Join("\n", output));
            Writer!.Write();
        }
    }
}