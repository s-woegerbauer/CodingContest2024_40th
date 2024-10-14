using System.Text;

namespace CodingContest2024_40th.Collections;

public class Grid<T>
{
    public int Rows => Data.GetLength(1);

    public int Columns => Data.GetLength(0);
    
    public T[,] Data { get; }

    public Grid(int rows, int columns)
    {
        Data = new T[rows, columns];
    }
    

    public Grid(T[,] data)
    {
        Data = data;
    }

    public T this[int row, int column]
    {
        get => Data[row, column];
        set => Data[row, column] = value;
    }
    
    public T this[Coordinates coordinates]
    {
        get => Data[coordinates.Y, coordinates.X];
        set => Data[coordinates.Y, coordinates.X] = value;
    }

    public Grid<T> Clone()
    {
        var clone = new Grid<T>(Rows, Columns);
        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                clone[i, j] = Data[i, j];
            }
        }

        return clone;
    }

    public string ToString(string separator)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < Rows; i++)
        {
            for (var j = 0; j < Columns; j++)
            {
                sb.Append(Data[i, j]);
                if (j < Columns - 1)
                {
                    sb.Append(separator);
                }
            }

            if (i < Rows - 1)
            {
                sb.AppendLine();
            }
        }
        
        return sb.ToString();
    }
}