using System.Text;

namespace CodingContest2024_40th.CodingContestHelper;

public class Reader : IDisposable
{
    private FileStream _fileStream;
    private StreamReader _reader;

    public Reader(string file)
    {
        _fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
        _reader = new StreamReader(_fileStream);
    }

    public IEnumerable<string> Read()
    {
        while (!_reader.EndOfStream)
        {
            yield return _reader.ReadLine()!;
        }
    }

    public void Dispose()
    {
        _reader?.Dispose();
        _fileStream?.Dispose();
    }
}