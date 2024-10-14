namespace CodingContest2024_40th.CodingContestHelper;

public static class Master
{
    private static readonly string InputDir = Path.Combine(Directory.GetCurrentDirectory(), Settings.InputFilePath);
    private static readonly string TestOutput = Path.Combine(Directory.GetCurrentDirectory(), Settings.TestOutputFilePath);
    private static readonly string TestInput = Path.Combine(Directory.GetCurrentDirectory(), Settings.TestInputFilePath);

    private static List<string> GetInputFiles()
    {
        return Directory.GetFiles(InputDir).ToList();
    }
    
    public static void Run()
    {
        List<string> inputFiles = GetInputFiles();
        
        foreach(var filePath in inputFiles)
        {
            InputOutput.Init(Path.GetFileName(filePath));
            List<string> input = InputOutput.ReadInput();
            List<string> output = Program.Solution(input);
            InputOutput.WriteOutput(output);
        }
    }

    public static void Test()
    {
        Reader reader = new Reader(Path.Combine(TestInput));
        List<string> input = reader.Read().ToList();
        List<string> output = Program.Solution(input);
        reader = new Reader(Path.Combine(TestOutput));
        List<string> expectedOutput = reader.Read().ToList();
        Tester tester = new Tester(output, expectedOutput);
        tester.RunTests();
    }
}