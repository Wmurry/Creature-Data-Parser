// See https://aka.ms/new-console-template for more information
public interface ICreatureDeserialzer
{
    List<CreatureDataParserApp.Creature> DerserializeFrom(string filename, string fileContents);
}