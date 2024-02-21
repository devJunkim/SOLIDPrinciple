namespace SingleResponsibility.Violates;

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

    /*This includes the persistence such as Save and Load.
     This has multiple responsibilities : Managing logs and persistence.
     This violates the single responsibility.
     */

    public void Save(string fileName)
    {
        File.WriteAllText(fileName, ToString());
    }

    public void Load(string fileName)
    {
        //Implement load from file
    }

    public void Load(Uri uri)
    {
        //Implement load from another source.
    }
}