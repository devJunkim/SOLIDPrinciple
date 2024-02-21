namespace SingleResponsibility.Refactor;

public class Persistence
{
    public void SaveToFile(Log log, string fileName, bool overwrite = false)
    {
        if (overwrite || !File.Exists(fileName))
        {
            File.WriteAllText(fileName, log.ToString());
        }
    }
}