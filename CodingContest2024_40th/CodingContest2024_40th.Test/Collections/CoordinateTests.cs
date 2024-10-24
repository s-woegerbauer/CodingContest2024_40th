using Xunit;
using CodingContest2024_40th.Collections;

namespace CodingContest2024_40th.Test.Collections
{
    public class CoordinateTests
    {
        [Fact]
        public void AddCoordinates_WithinBounds()
        {
            var coord1 = new Coordinates(1, 1);
            var coord2 = new Coordinates(2, 2);
            coord1.Add(coord2);
            Xunit.Assert.Equal(3, coord1.X);
            Xunit.Assert.Equal(3, coord1.Y);
        }

        [Fact]
        public void AddCoordinates_ExceedingMaxBounds()
        {
            var coord1 = new Coordinates(1, 1, maxX: 3, maxY: 3);
            var coord2 = new Coordinates(3, 3);
            coord1.Add(coord2);
            Xunit.Assert.Equal(3, coord1.X);
            Xunit.Assert.Equal(3, coord1.Y);
        }

        [Fact]
        public void SubtractCoordinates_WithinBounds()
        {
            var coord1 = new Coordinates(5, 5);
            var coord2 = new Coordinates(2, 2);
            coord1.Subtract(coord2);
            Xunit.Assert.Equal(3, coord1.X);
            Xunit.Assert.Equal(3, coord1.Y);
        }

        [Fact]
        public void SubtractCoordinates_ExceedingMinBounds()
        {
            var coord1 = new Coordinates(1, 1, minX: 0, minY: 0);
            var coord2 = new Coordinates(2, 2);
            coord1.Subtract(coord2);
            Xunit.Assert.Equal(0, coord1.X);
            Xunit.Assert.Equal(0, coord1.Y);
        }

        [Fact]
        public void AddCoordinates_WithOverlap()
        {
            var coord1 = new Coordinates(1, 1, maxX: 3, maxY: 3, minX: 0, minY: 0, overlaps: true);
            var coord2 = new Coordinates(3, 3);
            coord1.Add(coord2);
            Xunit.Assert.Equal(1, coord1.X);
            Xunit.Assert.Equal(1, coord1.Y);
        }

        [Fact]
        public void SubtractCoordinates_WithOverlap()
        {
            var coord1 = new Coordinates(1, 1, maxX: 3, maxY: 3, minX: 0, minY: 0, overlaps: true);
            var coord2 = new Coordinates(2, 2);
            coord1.Subtract(coord2);
            Xunit.Assert.Equal(2, coord1.X);
            Xunit.Assert.Equal(2, coord1.Y);
        }
    }
}