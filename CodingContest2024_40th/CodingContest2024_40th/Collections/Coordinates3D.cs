namespace CodingContest2024_40th.Collections;

public class Coordinates3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    private int MaxX { get; }
    private int MaxY { get; }
    private int MaxZ { get; }
    private int MinX { get; }
    private int MinY { get; }
    private int MinZ { get; }
    private bool Overlaps { get; }

    public Coordinates3D(int x, int y, int z, int maxX = Int32.MaxValue, int maxY = Int32.MaxValue, int maxZ = Int32.MaxValue, int minX = Int32.MinValue, int minY = Int32.MinValue, int minZ = Int32.MinValue, bool overlaps = false)
    {
        X = x;
        Y = y;
        Z = z;
        MaxX = maxX;
        MaxY = maxY;
        MaxZ = maxZ;
        MinX = minX;
        MinY = minY;
        MinZ = minZ;
        Overlaps = overlaps;
    }

    public void Add(Coordinates3D coordinates)
    {
        X += coordinates.X;
        Y += coordinates.Y;
        Z += coordinates.Z;

        if (Overlaps)
        {
            if (X > MaxX) X = MinX + (X - MaxX);
            if (X < MinX) X = MaxX - (MinX - X);
            if (Y > MaxY) Y = MinY + (Y - MaxY);
            if (Y < MinY) Y = MaxY - (MinY - Y);
            if (Z > MaxZ) Z = MinZ + (Z - MaxZ);
            if (Z < MinZ) Z = MaxZ - (MinZ - Z);
        }
        else
        {
            if (X > MaxX) X = MaxX;
            if (X < MinX) X = MinX;
            if (Y > MaxY) Y = MaxY;
            if (Y < MinY) Y = MinY;
            if (Z > MaxZ) Z = MaxZ;
            if (Z < MinZ) Z = MinZ;
        }
    }

    public void Subtract(Coordinates3D coordinates)
    {
        X -= coordinates.X;
        Y -= coordinates.Y;
        Z -= coordinates.Z;

        if (Overlaps)
        {
            if (X > MaxX) X = MinX + (X - MaxX);
            if (X < MinX) X = MaxX - (MinX - X);
            if (Y > MaxY) Y = MinY + (Y - MaxY);
            if (Y < MinY) Y = MaxY - (MinY - Y);
            if (Z > MaxZ) Z = MinZ + (Z - MaxZ);
            if (Z < MinZ) Z = MaxZ - (MinZ - Z);
        }
        else
        {
            if (X > MaxX) X = MaxX;
            if (X < MinX) X = MinX;
            if (Y > MaxY) Y = MaxY;
            if (Y < MinY) Y = MinY;
            if (Z > MaxZ) Z = MaxZ;
            if (Z < MinZ) Z = MinZ;
        }
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}