using System;

namespace ConsoleApp1.Third
{
    class ChessParticipant
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Position { get; set; }

        public ChessParticipant(string name, string city, string position)
        {

            Name = name;
            City = city;
            Position = position;

        }

        public void Show()
        {
            Console.WriteLine($"{Name} из города {City} на турнире в качестве {Position}.");
        }

    }

    class Referee : ChessParticipant
    {
        public int Experience { get; set; }
        public int Age { get; set; }
        public Referee(string name, string city, string position, int experience, int age) : base(name, city, position)
        {
            Experience = experience;
            Age = age;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Имя: {Name}, возраст: {Age}, стаж работы: {Experience}\n");
        }
    }

    class Gamer : ChessParticipant
    {
        public int WinnerPlace { get; set; }
        public int Rating { get; set; }
        public Gamer(string name, string city, string position, int winnerPlace, int rating) : base(name, city, position)
        {
            WinnerPlace = winnerPlace;
            Rating = rating;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Участник {Name} с рейтингом {Rating} занял {WinnerPlace} место!\n");
        }
    }

    class GameSponsor : ChessParticipant
    {
        public int Investment { get; set; }
        public GameSponsor(string name, string city, string position, int investment) : base(name, city, position)
        {
            Investment = investment;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Спонсор сегодняшней игры {Name}, который инвестировал: {Investment}!\n");
        }
    }

    class Run
    {
        static void Main()
        {
            Random rnd = new Random();
            new Referee("Динар Иванюк", "Казань", "судья", rnd.Next(5, 25), rnd.Next(30, 60)).Show();
            new Gamer("Гарри Каспаров", "Баку", "участник", rnd.Next(1, 5),rnd.Next(2790, 2860)).Show();
            new GameSponsor("Билл Гейтс", "Сиэтл", "спонсор", rnd.Next(50500, 700700)).Show();
        }
    }
}
