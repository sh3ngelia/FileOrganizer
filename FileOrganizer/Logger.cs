using System.Text;

namespace FileOrganizer;

public static class Logger
{
    public static void LogToConsole(string message)
    {
        Console.Write($"\n{DateTime.Now}: {message} ");
    }

    public static void LogToFile(string message, string filePath)
    {
        byte[] data = Encoding.UTF8.GetBytes($"{DateTime.Now}: {message}{Environment.NewLine}");

        // Ensure directory exists | დავრწმუნდეთ რომ დირექტორია არსებობს
        string? dir = CustomPath.GetDirectoryName(filePath);
        if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        using FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
        fs.Write(data, 0, data.Length);
    }
}

