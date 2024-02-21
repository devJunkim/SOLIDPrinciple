namespace SingleResponsibility.Refactor;

public class Log
{
    private readonly List<string> _logs = new List<string>();

    private static int _logCount = 0;

    public int AddLogs(string log)
    {
        _logs.Add($"{++_logCount}: {log}");
        return _logCount;
    }

    public void RemoveLogs(int index)
    {
        _logs.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _logs);
    }
}