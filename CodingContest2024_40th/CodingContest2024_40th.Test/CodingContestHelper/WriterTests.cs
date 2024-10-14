using System;
using System.IO;
using Xunit;
using CodingContest2024_40th.CodingContestHelper;

namespace CodingContest2024_40th.Test.CodingContestHelper
{
    public class WriterTests : IDisposable
    {
        private readonly string _testFilePath;
        private Writer _writer;

        public WriterTests()
        {
            _testFilePath = Path.Combine(Directory.GetCurrentDirectory(), "output", "test.txt");
            _writer = new Writer(_testFilePath);
        }

        [Fact]
        public void Add_ShouldAppendTextToStringBuilder()
        {
            // Arrange
            string text = "Hello, World!";

            // Act
            _writer.Add(text);

            // Assert
            Xunit.Assert.Contains(text, _writer.ToString());
        }

        [Fact]
        public void Write_ShouldWriteTextToFile()
        {
            // Arrange
            string text = "Hello, World!";
            _writer.Add(text);

            // Act
            _writer.Write();
            _writer.Dispose();

            // Assert
            string fileContent = File.ReadAllText(_testFilePath);
            Xunit.Assert.Equal(text, fileContent);
        }

        public void Dispose()
        {
            _writer?.Dispose();
            if (File.Exists(_testFilePath))
            {
                File.Delete(_testFilePath);
            }
        }
    }
}