namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Monday;
            //Days yesterday = (Days)23;
            Days yesterday = (Days)6;
            Console.WriteLine(today);
            Console.WriteLine(yesterday);

            int number = (int) today;

            Console.WriteLine(number);

            //today = Enum.Parse<Days>("Friday1");
            //today = (Days)Enum.Parse(typeof(Days), "Friday");
            today = Enum.Parse<Days>("Friday");
            Console.WriteLine(today);

            //bool isParseSuccesfull = Enum.TryParse("Friday1", out today);
            bool isParseSuccesfull = Enum.TryParse<Days>("Friday1", out today);
            Console.WriteLine(isParseSuccesfull);
            Console.WriteLine(today);

            //bool isDefined = Enum.IsDefined((typeof(Days)), 24);
            bool isDefined = Enum.IsDefined((typeof(Days)), 24);
            Console.WriteLine(isDefined);
            isDefined = Enum.IsDefined((typeof(Days)), 3);
            Console.WriteLine(isDefined);
            isDefined = Enum.IsDefined((typeof(Days)), "Monday");
            Console.WriteLine(isDefined);
            isDefined = Enum.IsDefined((typeof(Days)), "Monday1");
            Console.WriteLine(isDefined);

            foreach (string name in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(name);
            }

            foreach (int value in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(value);
            }

            DietStatus status = DietStatus.NotFormulated | DietStatus.NotAnalyzed;
            Console.WriteLine(status);

            status = DietStatus.NotFormulated | DietStatus.Analyzed;
            if((status & DietStatus.Analyzed) == DietStatus.Analyzed)
            {
                Console.WriteLine("Diet is analyzed");
            }

            status = DietStatus.NotFormulated | DietStatus.NotAnalyzed;
            if ((status & DietStatus.Analyzed) == DietStatus.Analyzed)
            {
                Console.WriteLine("Diet is analyzed");
            }
        }
    }
}