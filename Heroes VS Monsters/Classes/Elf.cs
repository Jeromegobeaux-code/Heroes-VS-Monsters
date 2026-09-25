using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Classes
{
    internal class Elf : Heroes
    {
        

        public Elf(string name) : base(name)
        {
            Health -= 1;

        }


        public override void Attack(Characters target)
        {
            Console.WriteLine($"You attacks {target.Name}");
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

            int dammages1 = new Dice(1, 3).chiffre;
            int dammages2 = new Dice(1, 3).chiffre;
            target.Health -= dammages1+dammages2+bonus;
            Console.WriteLine($"It takes {dammages1+bonus} point of dammages");
            Console.WriteLine($"It takes {dammages2} point of dammages");
        }
        //ajouter une mécanique unique qui leur donne une 25% de chance de faire deux points de dégâts en plus
        //en echange ils ont moins de HP ?

    }
}
