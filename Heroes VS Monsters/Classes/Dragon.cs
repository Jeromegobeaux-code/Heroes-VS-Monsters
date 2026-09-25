using heroes_vs_monsters.classes;

namespace Heroes_VS_Monsters.Classes
{
    internal class Dragon : Monsters
    {
        int StaminaBonus { get; set; } = 1;

        public Dragon() : base()
        {

            Name = "Dragon";
            gold = new Dice(1, 7).chiffre+10;
            leather = new Dice(1, 5).chiffre;
            this.Jeton = "D";

        }

    }
}
