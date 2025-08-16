namespace FileOrganizer;

public class FileScanner
{
    public List<string> Scan(string folderPath)
    {
        List<string> files = new();
        try
        {
            if (Directory.Exists(folderPath))
            {
                RecursiveScan(folderPath, files);
            }
            else
            {
                throw new DirectoryNotFoundException($"The directory '{folderPath}' does not exist.");
            }
        }
        catch (Exception ex)
        {
            Logger.LogToConsole($"Error scanning folder: {ex.Message}");
            Logger.LogToFile($"Error scanning folder: {ex.Message}", "logs/error.log");
        }
        return files;
    }

    private void RecursiveScan(string folderPath, List<string> files)
    {
        foreach (var file in Directory.GetFiles(folderPath))
        {
            files.Add(file);
        }

        foreach (var dir in Directory.GetDirectories(folderPath))
        {
            RecursiveScan(dir, files);
        }
    }
}

