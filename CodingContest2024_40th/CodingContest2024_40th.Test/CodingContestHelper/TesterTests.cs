using Xunit;
using CodingContest2024_40th.CodingContestHelper;

namespace CodingContest2024_40th.Test.CodingContestHelper
{
    public class TesterTests
    {
        [Fact]
        public void RunTests_AllCorrect()
        {
            // Arrange
            var output = new List<string> { "line1", "line2", "line3" };
            var expectedOutput = new List<string> { "line1", "line2", "line3" };
            var tester = new Tester(output, expectedOutput);

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tester.RunTests();
                var result = sw.ToString();

                // Assert
                Xunit.Assert.Contains("Total Correct: 3", result);
                Xunit.Assert.Contains("Total Incorrect: 0", result);
                Xunit.Assert.Contains("Accuracy: 100%", result);
            }
        }

        [Fact]
        public void RunTests_SomeIncorrect()
        {
            // Arrange
            var output = new List<string> { "line1", "wrongLine", "line3" };
            var expectedOutput = new List<string> { "line1", "line2", "line3" };
            var tester = new Tester(output, expectedOutput);

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tester.RunTests();
                var result = sw.ToString();

                // Assert
                Xunit.Assert.Contains("Total Correct: 2", result);
                Xunit.Assert.Contains("Total Incorrect: 1", result);
                Xunit.Assert.Contains("Accuracy: 66,66666666666667%", result);
            }
        }

        [Fact]
        public void RunTests_MissingLines()
        {
            // Arrange
            var output = new List<string> { "line1" };
            var expectedOutput = new List<string> { "line1", "line2", "line3" };
            var tester = new Tester(output, expectedOutput);

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tester.RunTests();
                var result = sw.ToString();

                // Assert
                Xunit.Assert.Contains("Total Correct: 1", result);
                Xunit.Assert.Contains("Total Incorrect: 2", result);
                Xunit.Assert.Contains("Accuracy: 33,333333333333336%", result);
            }
        }
    }
}