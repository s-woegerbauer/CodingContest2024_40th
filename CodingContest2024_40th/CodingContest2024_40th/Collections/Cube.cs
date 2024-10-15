using System.Text;

namespace CodingContest2024_40th.Collections;

public class Cube<T>
{
    public T[,,] Data { get; }
    public int Length => Data.GetLength(0);
    public int Width => Data.GetLength(1);
    public int Height => Data.GetLength(2);
    
    public Cube(int x, int y, int z)
    {
        Data = new T[x, y, z];
    }
    
    public Cube(T[,,] data)
    {
        Data = data;
    }
    
    public T this[int x, int y, int z]
    {
        get => Data[x, y, z];
        set => Data[x, y, z] = value;
    }
    
    public void Fill(T value)
    {
        for (var x = 0; x < Data.GetLength(0); x++)
        {
            for (var y = 0; y < Data.GetLength(1); y++)
            {
                for (var z = 0; z < Data.GetLength(2); z++)
                {
                    Data[x, y, z] = value;
                }
            }
        }
    }
    
    public void Fill(Func<int, int, int, T> valueFunction)
    {
        for (var x = 0; x < Data.GetLength(0); x++)
        {
            for (var y = 0; y < Data.GetLength(1); y++)
            {
                for (var z = 0; z < Data.GetLength(2); z++)
                {
                    Data[x, y, z] = valueFunction(x, y, z);
                }
            }
        }
    }
    
    public override string ToString()
    {
        var result = new StringBuilder();
        for (var x = 0; x < Data.GetLength(0); x++)
        {
            for (var y = 0; y < Data.GetLength(1); y++)
            {
                for (var z = 0; z < Data.GetLength(2); z++)
                {
                    result.Append(Data[x, y, z]!.ToString());
                    result.Append(' ');
                }
                result.AppendLine();
            }
            result.AppendLine();
        }
        return result.ToString();
    }
}