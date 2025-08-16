namespace FileOrganizer;

public class FileOrganizer
{
    public string GetTargetFolder(string filePath)
    {
        string extension = CustomPath.GetExtension(filePath).TrimStart('.');
        var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["jpg"] = "Images",
            ["jpeg"] = "Images",
            ["png"] = "Images",
            ["gif"] = "Images",

            ["mp3"] = "Audio",
            ["wav"] = "Audio",
            ["flac"] = "Audio",

            ["mp4"] = "Videos",
            ["avi"] = "Videos",
            ["mkv"] = "Videos",

            ["doc"] = "Documents",
            ["docx"] = "Documents",
            ["pdf"] = "Documents",
            ["txt"] = "Documents"
        };

        // Check dictionary for extension; return category if found, otherwise "Others"
        // შევამოწმოთ არსებობს თუ არა ამ გაფართოების კატეგორია და თუ არა, დავაბრუნოთ "Others"
        return map.TryGetValue(extension, out var category) ? category : "Others";
    }
}
