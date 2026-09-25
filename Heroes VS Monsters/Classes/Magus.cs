using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Classes
{
    internal class Magus:Heroes
    {
        private int charge; 
        
        public Magus(string name) { this.Name = name; Stamina -= 4; Strenght = 0; }

        public override void Attack(Characters target)
        {
            int choice;
            if(charge < 3) 
            { 
                bool bChoice;   
                Console.WriteLine($"You've got {charge} charges\nWhat do you want to ? 1.Charging your man 2.Casting a spell");
                do
                {
                    bChoice = int.TryParse(Console.ReadLine(), out choice);
                } while (!bChoice);
            }
            else 
            {
                Console.WriteLine("You fell the mana overflowing in your body... you have no choice but to cast a spell");
                choice = 2; 
            }

            if(choice == 1) { ChargeUp(); }
            else 
            { 
                switch(charge) 
                { 
                    case 0:
                        Tickles(target);
                        break;
                    case 1:
                        Fireball(target);
                        break; 
                    case 2:
                        RedThunder(target);
                        break;
                    case 3:
                        Inferno(target);
                        break;
                }
            }
        }

        private void ChargeUp()
        {
            Console.WriteLine("You canalysing your mana to prepare a spell");
            charge++; 
        }

        private void Tickles(Characters target) 
        { 
            int dammages = new Dice(1, 3).chiffre;
            Console.WriteLine($"You strike your opponent with your staff... the {target.Name} takes {dammages} dammages");
            target.Health -= dammages;
        }
        private void Fireball(Characters target) 
        {
            int dammages = new Dice(2, 8).chiffre;
            Console.WriteLine($"You cast a shiny fireball ! The {target.Name} takes {dammages} dammages");
            target.Health -= dammages;
            charge = 0; 
        }
        private void RedThunder(Characters target) 
        {
            int dammages = new Dice(3, 8).chiffre + new Dice(3, 8).chiffre;
            Console.WriteLine($"You strikes you ennemy with a red thundertruck ! The {target.Name} takes {dammages} dammages");
            target.Health -= dammages;
            charge = 0; 
        } 
        private void Inferno(Characters target) 
        {
            int dammages = new Dice(4, 10).chiffre + new Dice(4, 8).chiffre;
            Console.WriteLine($"You unleash a powerfull fire on your ennemy! The {target.Name} takes {dammages} dammages");
            target.Health -= dammages;
            charge = 0; 
        } 

        //créer un perso qui peut charger son attaque, plus il charge de tours plus il fera mal
        //peut charger 3 fois max, chaque charge fait un sort différent
        //0 de charge = tape avec son bâton => 1d2 de dégâts
        //1 de charge = boule de feu => 1dé qui fait 3 à 7 dégâts
        //2 de charge = pyro-eclair => 2dé qui font 3 à 7 dégâts
        //3 de charge = Inferno => 4dé qui font de 3à 5 dégats
        //compensation : -3 de stamina et 0 de force

    }
}
