// See https://aka.ms/new-console-template for more information
public interface IUserInteractor
{
    string ReadValidFilePath();
    void PrintMessage(string message);
    void PrintError(string v);
}
