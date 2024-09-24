// See https://aka.ms/new-console-template for more information
using System.Text.Json;

public partial class CreatureDataParserApp
{
    private readonly IUserInteractor _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly ICreatureDeserialzer _videogamesdeserialzer;
    private readonly IFileReader _fileReader;


    public CreatureDataParserApp(IUserInteractor userInteractor, 
        IGamesPrinter gamesPrinter,
        ICreatureDeserialzer videogamesdeserialzer,
        IFileReader fileReader)
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videogamesdeserialzer = videogamesdeserialzer;
        _fileReader = fileReader;
    }

    public void Run()
    {
        string filename = _userInteractor.ReadValidFilePath();
        var fileContents = _fileReader.Read(filename);
        List<Creature> videoGames = _videogamesdeserialzer.DerserializeFrom(filename, fileContents);
        _gamesPrinter.Print(videoGames);
    }        

    
}
