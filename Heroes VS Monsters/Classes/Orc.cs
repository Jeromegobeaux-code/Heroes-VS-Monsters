using Heroes_VS_Monsters.Classes;

namespace heroes_vs_monsters.classes
{
    internal class Orc : Monsters
    {
        int strenghtbonus { get; set; } = 1;

        public Orc() : base()
        {
            Name = "Orc";
            gold = new Dice(1, 7).chiffre;
            this.Jeton = "O";
        }



    }
}
