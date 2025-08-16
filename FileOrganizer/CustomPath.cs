namespace FileOrganizer;

public static class CustomPath
{
    public static string GetExtension(string filePath)
    {
        int index = filePath.LastIndexOf('.');
        return index >= 0 ? filePath.Substring(index).ToLowerInvariant() : "";
    }

    public static string GetFileNameWithoutExtension(string filePath)
    {
        string fileName = GetFileName(filePath);
        int index = fileName.LastIndexOf('.');
        return index >= 0 ? fileName.Substring(0, index) : fileName;
    }

    public static string GetFileName(string filePath)
    {
        int index = filePath.LastIndexOfAny(new[] { '\\', '/' });
        return index >= 0 ? filePath.Substring(index + 1) : filePath;
    }

    public static string GetDirectoryName(string filePath)
    {
        int index = filePath.LastIndexOfAny(new[] { '\\', '/' });
        return index >= 0 ? filePath.Substring(0, index) : "";
    }

    public static string Combine(string part1, string part2)
    {
        if (string.IsNullOrEmpty(part1)) return part2;
        if (string.IsNullOrEmpty(part2)) return part1;

        if (!part1.EndsWith("\\") && !part1.EndsWith("/"))
            part1 += "\\";

        return part1 + part2;
    }
}

