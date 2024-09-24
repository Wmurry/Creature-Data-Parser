// See https://aka.ms/new-console-template for more information

var userInteractor = new ConsoleUserInteractor();

var app = new CreatureDataParserApp(userInteractor,
    new CreaturePrinter(userInteractor),
    new CreatureDeserialzer(userInteractor),
    new LocalFileReader());

var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{ 
    Console.WriteLine("Sorry! the application has expired an " +
        "unexpected error and will have to be closed");
    logger.Log(ex);
}

Console.WriteLine("Press any key to close");
Console.ReadKey();
