using Heroes_VS_Monsters.Classes;

namespace heroes_vs_monsters.classes
{
    internal class Wolf : Monsters
    {
        

        public Wolf() : base()
        {

            Name = "Wolf";
            leather = new Dice(1, 5).chiffre;
            this.Jeton = "W";
        }
    }
}
