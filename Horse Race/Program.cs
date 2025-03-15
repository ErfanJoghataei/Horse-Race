using System.Collections.Concurrent;
using System.Runtime;

namespace Horse_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string wheather = "normal";

            Race race = new Race(50, wheather);
            race.addhorse("jack");
            race.addhorse("jesy");
            race.addhorse("white");
            race.addhorse("black");
            Console.WriteLine("the race is started enter the horse name you eant to bet:  ");
            string name = Console.ReadLine();
            race.Start();
            if (name == race.Winner)
            {
                Console.WriteLine("Your horse is win");
            }
            else
            {
                Console.WriteLine("your horse lose");
            }







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
            var wheather = Wheather.ToLower();
            if (wheather == "normal")
            {
                Distance += random.Next(3, 5);
            }
            else if (wheather == "rainy")
            {
                Distance += random.Next(0, 2);
            }

            else if (wheather == "snowy")
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
        public string Winner { get; private set; } = "";
        private bool RunTurn()
        {
            bool finished = false;
            foreach (var horse in horses)
            {
                horse.Run();
                Console.WriteLine($"Horse Name is {horse.Horsename} horse distance {new string('-', horse.Distance)} ♠");
                if (horse.Distance >= TrackLenth && Winner == "")
                {
                    Console.WriteLine($"{horse.Horsename} is win!");
                    Winner = horse.Horsename;
                    finished = true;
                }

            }
            return finished;
        }
    }
}
