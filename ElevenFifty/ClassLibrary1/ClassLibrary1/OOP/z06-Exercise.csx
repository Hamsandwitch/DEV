#r "System.Windows.Forms.dll"
using System;
using System.Windows.Forms;

public interface ILogger
{
    void LogError(string message);
    void LogWarning(string message);
    void LogInfo(string message);

}
public class Logger
    : ILogger
{
    public static readonly string ErrorLabel = "ERROR";
    public static readonly string WarningLabel = "WARNING";
    public static readonly string InfoLabel = "INFO";



    protected virtual void WriteMessage(string severity, string message)
    {
        Console.WriteLine($"[{severity} - {DateTime.UtcNow:O}] {message}");

    }

    public void LogError(string message)
    {
        WriteMessage(ErrorLabel, message);
    }

    public void LogWarning(string message)
    {
        WriteMessage(WarningLabel, message);
    }
    public void LogInfo(string message)
    {
        WriteMessage(InfoLabel, message);
    }
}

ILogger cg = new Logger();

public class WindowsLogger
    : Logger
{
    protected override void WriteMessage(string severity, string message)
    {
        MessageBox.Show($" {severity}! - There was a  problem... please format your Kernel values.");
    }
}
ILogger wg = new WindowsLogger();