// See https://aka.ms/new-console-template for more information
public class LocalFileReader : IFileReader
{
    public string Read(string filename)
    {
        return File.ReadAllText(filename);  
    }
}
