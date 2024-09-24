// See https://aka.ms/new-console-template for more information
public class ConsoleUserInteractor : IUserInteractor
{
    public void PrintMessage(string message)
    { 
        Console.WriteLine(message); 
    }

    public void PrintError(string message)
    {
        var OriginalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = OriginalColor;
    }

    public string ReadValidFilePath()
    {
        bool isFilePathVaild = false;
        string filename = default;
        do
        {
            try
            {
                Console.WriteLine("Enter The file you want to read");
                filename = Console.ReadLine();

                if (filename == null)
                {
                    Console.WriteLine("The file name cannot be null");
                }
                else if (filename == string.Empty)
                {
                    Console.WriteLine("The file name cannot be empty");
                }
                else if (!File.Exists(filename))
                {
                    Console.WriteLine("The file name cannot be found");
                }
                else
                {
                    isFilePathVaild = true;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("The file name cannot be null.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("The file name cannot be empty.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file does not exist.");
            }
        }
        while (!isFilePathVaild);
        return filename;
    }
}
