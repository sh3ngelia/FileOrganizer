namespace FileOrganizer;

public class FileFilter
{
    public List<string> Filter(List<string> files, string[] extensions)
    {
        List<string> result = new();
        foreach (var file in files)
        {
            string ext = CustomPath.GetExtension(file);
            if (Array.Exists(extensions, e => e.Equals(ext, StringComparison.OrdinalIgnoreCase)))
            {
                result.Add(file);
            }
        }
        return result;
    }
}

