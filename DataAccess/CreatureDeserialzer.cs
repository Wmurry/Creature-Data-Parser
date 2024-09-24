// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using static CreatureDataParserApp;

public class CreatureDeserialzer : ICreatureDeserialzer
{
    private readonly IUserInteractor _userInteractor;

    public CreatureDeserialzer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    List<CreatureDataParserApp.Creature> ICreatureDeserialzer.DerserializeFrom(string filename, string fileContents)
    {
        try
        {
            return JsonSerializer.Deserialize<List<Creature>>(fileContents);
        }
        catch (JsonException ex)
        {
            _userInteractor.PrintError($"JSON in {filename} was not in a valid JSON" +
                $"format. JSON body:");
            _userInteractor.PrintError(fileContents);

            throw new JsonException($"{ex.Message} the file is: {filename}", ex);
        }
    }
}
