using System;

namespace CodingContest2024_40th.CodingContestHelper;

public class Tester
{
    private readonly List<string> _output;
    private readonly List<string> _expectedOutput;

    public Tester(List<string> output, List<string> expectedOutput)
    {
        _output = output;
        _expectedOutput = expectedOutput;
    }

    public void RunTests()
    {
        int correctCount = 0;
        int incorrectCount = 0;

        Console.WriteLine("Test Results:");
        Console.WriteLine("-------------");

        int maxLength = Math.Max(_output.Count, _expectedOutput.Count);
        for (int i = 0; i < maxLength; i++)
        {
            string outputLine = i < _output.Count ? _output[i] : "<missing>";
            string expectedLine = i < _expectedOutput.Count ? _expectedOutput[i] : "<missing>";

            if (outputLine == expectedLine)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Line {i + 1}: OK");
                correctCount++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Line {i + 1}: WRONG");
                Console.WriteLine($"  Output:   {outputLine}");
                Console.WriteLine($"  Expected: {expectedLine}");
                incorrectCount++;
            }
            Console.ResetColor();
        }

        Console.WriteLine("-------------");
        Console.WriteLine($"Total Correct: {correctCount}");
        Console.WriteLine($"Total Incorrect: {incorrectCount}");
        Console.WriteLine($"Accuracy: {(correctCount * 100.0) / Math.Max(_output.Count, _expectedOutput.Count)}%");
    }
}