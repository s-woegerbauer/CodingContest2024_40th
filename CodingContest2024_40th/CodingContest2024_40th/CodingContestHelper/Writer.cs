using System.Text;

namespace CodingContest2024_40th.CodingContestHelper;

public class Writer : IDisposable
{
    private readonly StringBuilder _stringBuilder;
    private readonly FileStream _fileStream;
    private bool _disposed = false;

    public Writer(string file)
    {
        _fileStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
        _stringBuilder = new StringBuilder();
    }

    public void Add(string text)
    {
        _stringBuilder.Append(text);
    }

    public void Write()
    {
        byte[] info = new UTF8Encoding(true).GetBytes(_stringBuilder.ToString());
        _fileStream.Write(info, 0, info.Length);
    }

    public override string ToString()
    {
        return _stringBuilder.ToString();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _fileStream?.Dispose();
            }
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}