using System.Collections.Concurrent;
using System.Runtime;

namespace Horse_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string wheather = "rainy";

            Race race = new Race(70, wheather);
            race.addhorse("jack");
            race.addhorse("jesy");
            race.addhorse("white");
            race.addhorse("black");
            Console.WriteLine("the race is started pleas enter to start: ");
           
            Console.ReadLine();

            race.Start();

        }
    }
    public class Horse
    {
        public string Horsename { get; set; }
        public string Wheather { get; set; }
        public int Distance { get; set; } = 0;
        private Random random = new Random();
        public Horse(string horename, string wheather)
        {
            Horsename = horename;
            Wheather = wheather;
        }
        public void Run()
        {
            if (Wheather == "normal".ToLower())
            {
                Distance += random.Next(3, 5);
            }
            else if (Wheather == "rainy".ToLower())
            {
                Distance += random.Next(0, 2);
            }


            else if (Wheather == "snowyi".ToLower())
            {
                Distance += random.Next(0, 1);
            }
        }
    }
    public class Race
    {
        private List<Horse> horses = new List<Horse>();
        private int TrackLenth;
        public string Weather { get; set; }
        public Race(int lenth, string weather)
        {
            TrackLenth = lenth;
            Weather = weather;
        }

        public void addhorse(string horsename)
        {
            horses.Add(new Horse(horsename, Weather));
        }
        public void Start()
        {
            bool raceOver = false;
            while (!raceOver)
            {
                Console.Clear();
                raceOver = RunTurn();
                System.Threading.Thread.Sleep(10);
            }


        }
        private bool RunTurn()
        {
            bool finished = false;
            foreach (var horse in horses)
            {
                horse.Run();
                Console.WriteLine($"Horse Name is {horse.Horsename} horse distance {new string('-', horse.Distance)} ♠");
                if (horse.Distance >= TrackLenth)
                {
                    Console.WriteLine($"{horse.Horsename} is win!");
                    finished = true;
                }

            }
            return finished;
        }
    }
}
