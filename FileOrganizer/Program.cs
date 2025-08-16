namespace FileOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test is from AI
            // ტესტის დასაგენერირებლად გამოყენებულია AI
            Logger.LogToConsole("Enter folder path:");
            string folderPath = Console.ReadLine() ?? "";

            Logger.LogToConsole("Enter extensions (comma separated, e.g. .jpg,.png,.docx):");
            string[] extensions = (Console.ReadLine() ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries);

            FileScanner scanner = new();
            FileFilter filter = new();
            FileOrganizer organizer = new();
            FileCopier copier = new();

            List<string> allFiles = scanner.Scan(folderPath);
            List<string> filtered = filter.Filter(allFiles, extensions);

            foreach (var file in filtered)
            {
                string targetFolder = organizer.GetTargetFolder(file);
                string fileName = CustomPath.GetFileName(file);
                string destinationDir = CustomPath.Combine(folderPath, targetFolder);
                if (!Directory.Exists(destinationDir)) Directory.CreateDirectory(destinationDir);
                string destinationFile = CustomPath.Combine(destinationDir, fileName);

                copier.CustomMove(file, destinationFile);
                Logger.LogToConsole($"Moved {file} -> {destinationFile}");
                Logger.LogToFile($"Moved {file} -> {destinationFile}", "logs/actions.log");
            }

            Logger.LogToConsole("Operation completed!");
        }
    }
}
