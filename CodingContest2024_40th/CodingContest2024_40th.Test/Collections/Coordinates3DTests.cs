using CodingContest2024_40th.Collections;
using Xunit;

namespace CodingContest2024_40th.Test.Collections;

public class Coordinates3DTests
{
    [Fact]
    public void Add_WhenOverlaps_ShouldWrapAround()
    {
        // Arrange
        var coordinates = new Coordinates3D(0, 0, 0, 2, 2, 2, -2, -2, -2, true);
        var other = new Coordinates3D(3, 3, 3);

        // Act
        coordinates.Add(other);

        // Assert
        Xunit.Assert.Equal(-1, coordinates.X);
        Xunit.Assert.Equal(-1, coordinates.Y);
        Xunit.Assert.Equal(-1, coordinates.Z);
    }

    [Fact]
    public void Add_WhenNotOverlaps_ShouldNotWrapAround()
    {
        // Arrange
        var coordinates = new Coordinates3D(0, 0, 0, 2, 2, 2, -2, -2, -2, false);
        var other = new Coordinates3D(3, 3, 3);

        // Act
        coordinates.Add(other);

        // Assert
        Xunit.Assert.Equal(2, coordinates.X);
        Xunit.Assert.Equal(2, coordinates.Y);
        Xunit.Assert.Equal(2, coordinates.Z);
    }

    [Fact]
    public void Subtract_WhenOverlaps_ShouldWrapAround()
    {
        // Arrange
        var coordinates = new Coordinates3D(0, 0, 0, 2, 2, 2, -2, -2, -2, true);
        var other = new Coordinates3D(3, 3, 3);

        // Act
        coordinates.Subtract(other);

        // Assert
        Xunit.Assert.Equal(1, coordinates.X);
        Xunit.Assert.Equal(1, coordinates.Y);
        Xunit.Assert.Equal(1, coordinates.Z);
    }

    [Fact]
    public void Subtract_WhenNotOverlaps_ShouldNotWrapAround()
    {
        // Arrange
        var coordinates = new Coordinates3D(0, 0, 0, 2, 2, 2, -2, -2, -2, false);
        var other = new Coordinates3D(3, 3, 3);

        // Act
        coordinates.Subtract(other);

        // Assert
        Xunit.Assert.Equal(-2, coordinates.X);
        Xunit.Assert.Equal(-2, coordinates.Y);
        Xunit.Assert.Equal(-2, coordinates.Z);
    }
}