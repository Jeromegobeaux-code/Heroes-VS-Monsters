using Heroes_VS_Monsters.Classes;

namespace heroes_vs_monsters.classes
{
    public abstract class Monsters : Characters
    {



        public int XP = new Dice(2, 5).chiffre;

        public Monsters() : base()
        {
            Name = "monster";
            this.Jeton = "M";

        }

        public override void Attack(Characters target)
        {
            Console.WriteLine($"It attacks you");
            int dammages = new Dice(1, 5).chiffre;
            target.Health -= dammages;
            Console.WriteLine($"You takes {dammages} point of dammages", Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
