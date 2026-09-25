using Heroes_VS_Monsters.Classes;
using Heroes_VS_Monsters.Utils;
using System.Numerics;

namespace Heroes_VS_Monsters.Classes
{
    public abstract class Characters
    {

        public string Jeton { get; set; }

        public int Health { get; set; }

        public string Name { get; set; }

        private int SetHealth()
        {
            switch (Stamina)
            {
                case < 5:
                    return Stamina -1;
             
                case < 10:
                    return Stamina;

                case < 15:
                    return Stamina+1;

                case >= 15:
                    return Stamina+2;

            }

        }
        public int Strenght { get; protected set; } 
        public int Stamina { get; protected set; }

        public int MahHealth { get; }

        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public Characters() 
        {
            Stamina = CharactersSystem.StatAtrribution();
            Strenght = CharactersSystem.StatAtrribution();
            Health = SetHealth();
            MahHealth = SetHealth();
            this.Jeton = "?";
            this.Name = "?";
        }

        public int leather { get; set; }

        public int gold { get; set; }

        public virtual void Attack(Characters target)
        {
            Console.WriteLine($"You attacks {target.Name}");
            int dammages = new Dice(1, 5).chiffre;
            int bonus;
            switch (this.Strenght)
            {
                case < 5:
                    bonus = -1;
                    break;
                case < 10:
                    bonus = 0;
                    break;

                case < 15:
                    bonus = +1;
                    break;

                case >= 15:
                    bonus = +2;
                    break;
            }
            target.Health -= dammages+bonus;
            Console.WriteLine($"It takes {dammages+bonus} point of dammages");
        }

        //faire une méthode abstract "death"
        //pour héros => appel Utils.GameOver
        //pour monstre => les deletes de la zone de jeu


        //modifier système bonus pour respecter consigne
    }
}
