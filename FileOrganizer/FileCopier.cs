namespace FileOrganizer;

public class FileCopier
{
    public void CustomCopy(string sourceFile, string destinationFile)
    {
        byte[] buffer = new byte[4096];
        using FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        using FileStream destination = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);

        int bytesRead;
        while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
        {
            destination.Write(buffer, 0, bytesRead);
        }
    }

    public void CustomDelete(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }

    public void CustomMove(string sourceFile, string destinationFile)
    {
        CustomCopy(sourceFile, destinationFile);
        CustomDelete(sourceFile);
    }
}


