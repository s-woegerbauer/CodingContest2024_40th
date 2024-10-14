namespace CodingContest2024_40th.Collections;

public class Coordinates
{
    public int X { get; set; }
    public int Y { get; set; }
    private int MaxX { get; }
    private int MaxY { get; }
    private int MinX { get; }
    private int MinY { get; }
    private bool Overlaps { get; }

    public Coordinates(int x, int y, int maxX = Int32.MaxValue, int maxY = Int32.MaxValue, int minX = Int32.MinValue, int minY = Int32.MinValue, bool overlaps = false)
    {
        X = x;
        Y = y;
        MaxX = maxX;
        MaxY = maxY;
        MinX = minX;
        MinY = minY;
        Overlaps = overlaps;
    }
    
    public void Add(Coordinates coordinates)
    {
        X += coordinates.X;
        Y += coordinates.Y;

        if (Overlaps)
        {
            if (X > MaxX) X = MinX + (X - MaxX - 1);
            if (X < MinX) X = MaxX - (MinX - X - 1);
            if (Y > MaxY) Y = MinY + (Y - MaxY - 1);
            if (Y < MinY) Y = MaxY - (MinY - Y - 1);
        }
        else
        {
            if (X > MaxX) X = MaxX;
            if (X < MinX) X = MinX;
            if (Y > MaxY) Y = MaxY;
            if (Y < MinY) Y = MinY;
        }
    }
    
    public void Subtract(Coordinates coordinates)
    {
        X -= coordinates.X;
        Y -= coordinates.Y;

        if (Overlaps)
        {
            if (X > MaxX) X = MinX + (X - MaxX - 1);
            if (X < MinX) X = MaxX - (MinX - X - 1);
            if (Y > MaxY) Y = MinY + (Y - MaxY - 1);
            if (Y < MinY) Y = MaxY - (MinY - Y - 1);
        }
        else
        {
            if (X > MaxX) X = MaxX;
            if (X < MinX) X = MinX;
            if (Y > MaxY) Y = MaxY;
            if (Y < MinY) Y = MinY;
        }
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}