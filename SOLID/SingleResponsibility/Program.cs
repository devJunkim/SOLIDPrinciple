// See https://aka.ms/new-console-template for more information

using SingleResponsibility.Refactor;
// This is for violating principle
//using Log = SingleResponsibility.Violates.Log;

using Log = SingleResponsibility.Refactor.Log;

Console.WriteLine("Hello, World!");

var log = new Log();
log.AddLogs("First Log");
log.AddLogs("Second Log");

Console.WriteLine(log.ToString());

var persistence = new Persistence();
var fileName = $"{AppContext.BaseDirectory}\\log.txt";
persistence.SaveToFile(log, fileName, true);
