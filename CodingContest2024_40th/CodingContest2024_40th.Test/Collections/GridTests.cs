using Xunit;
using CodingContest2024_40th.Collections;

namespace CodingContest2024_40th.Test.Collections
{
    public class GridTests
    {
        [Fact]
        public void Constructor_ShouldInitializeGridWithGivenDimensions()
        {
            var grid = new Grid<int>(3, 4);
            Xunit.Assert.Equal(3, grid.Rows);
            Xunit.Assert.Equal(4, grid.Columns);
        }

        [Fact]
        public void Indexer_ShouldGetAndSetValues()
        {
            var grid = new Grid<int>(2, 2);
            grid[0, 0] = 1;
            grid[1, 1] = 2;
            Xunit.Assert.Equal(1, grid[0, 0]);
            Xunit.Assert.Equal(2, grid[1, 1]);
        }

        [Fact]
        public void Clone_ShouldCreateDeepCopyOfGrid()
        {
            var grid = new Grid<int>(2, 2);
            grid[0, 0] = 1;
            grid[1, 1] = 2;
            var clone = grid.Clone();
            Xunit.Assert.Equal(1, clone[0, 0]);
            Xunit.Assert.Equal(2, clone[1, 1]);
            clone[0, 0] = 3;
            Xunit.Assert.Equal(1, grid[0, 0]); // Ensure original grid is not modified
        }

        [Fact]
        public void ToString_ShouldReturnFormattedString()
        {
            var grid = new Grid<int>(2, 2);
            grid[0, 0] = 1;
            grid[0, 1] = 2;
            grid[1, 0] = 3;
            grid[1, 1] = 4;
            var result = grid.ToString(",");
            Xunit.Assert.Equal("1,2\r\n3,4", result);
        }
    }
}