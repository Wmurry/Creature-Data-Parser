// See https://aka.ms/new-console-template for more information

public partial class CreatureDataParserApp
{
    public class Creature
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        public string TimePeriod { get; set; }

        public override string ToString()
        {
            return $"{Name}, Size: {Size} meters," +
                 $" Time : {TimePeriod} period";
        }
    }
}