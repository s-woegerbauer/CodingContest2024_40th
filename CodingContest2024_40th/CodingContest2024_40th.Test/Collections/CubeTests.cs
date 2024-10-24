using Xunit;
using CodingContest2024_40th.Collections;

namespace CodingContest2024_40th.Test.Collections
{
    public class CubeTests
    {
        [Fact]
        public void Constructor_ShouldInitializeWithCorrectDimensions()
        {
            var cube = new Cube<int>(3, 4, 5);
            Xunit.Assert.Equal(3, cube.Length);
            Xunit.Assert.Equal(4, cube.Width);
            Xunit.Assert.Equal(5, cube.Height);
        }

        [Fact]
        public void Indexer_ShouldGetAndSetValues()
        {
            var cube = new Cube<int>(2, 2, 2);
            cube[0, 0, 0] = 42;
            Xunit.Assert.Equal(42, cube[0, 0, 0]);
        }

        [Fact]
        public void Fill_ShouldSetAllValuesToGivenValue()
        {
            var cube = new Cube<int>(2, 2, 2);
            cube.Fill(5);
            for (int x = 0; x < cube.Length; x++)
            {
                for (int y = 0; y < cube.Width; y++)
                {
                    for (int z = 0; z < cube.Height; z++)
                    {
                        Xunit.Assert.Equal(5, cube[x, y, z]);
                    }
                }
            }
        }

        [Fact]
        public void Fill_WithFunction_ShouldSetAllValues()
        {
            var cube = new Cube<int>(2, 2, 2);
            cube.Fill((x, y, z) => x + y + z);
            for (int x = 0; x < cube.Length; x++)
            {
                for (int y = 0; y < cube.Width; y++)
                {
                    for (int z = 0; z < cube.Height; z++)
                    {
                        Xunit.Assert.Equal(x + y + z, cube[x, y, z]);
                    }
                }
            }
        }

        [Fact]
        public void ToString_ShouldReturnCorrectStringRepresentation()
        {
            var cube = new Cube<int>(2, 2, 2);
            cube.Fill((x, y, z) => x + y + z);
            var expected = "0 1 \r\n1 2 \r\n\r\n1 2 \r\n2 3 \r\n\r\n";
            Xunit.Assert.Equal(expected, cube.ToString());
        }
    }
}