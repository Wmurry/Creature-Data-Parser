// See https://aka.ms/new-console-template for more information
public class CreaturePrinter : IGamesPrinter
{
    private readonly IUserInteractor _userInteractor;

    public CreaturePrinter(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public void Print(List<CreatureDataParserApp.Creature> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.PrintMessage(Environment.NewLine + "Loaded games are:");
            foreach (var videogame in videoGames)
            {
                _userInteractor.PrintMessage(videogame.ToString());
            }
        }
        else
        {
            _userInteractor.PrintMessage("No games are present in the input file");
        }
    }
}
