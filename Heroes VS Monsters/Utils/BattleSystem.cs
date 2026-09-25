using heroes_vs_monsters.classes;
using Heroes_VS_Monsters.Classes;

namespace Heroes_VS_Monsters.Utils
{
    internal class BattleSystem
    {

        private static void BattleSprite(Monsters ennemy) 
        {
            if (ennemy is Dragon)
            {
                Console.WriteLine("       \\(______     ______)/\r\n       /`.----.\\   /.----.`\\\r\n      } /      :} {:      \\ {\r\n     / {        } {        } \\\r\n     } }      ) } { (      { {\r\n    / {      /|\\}!{/|\\      } \\\r\n    } }     ( (.\"^\".) )     { {\r\n   / {       (d\\   /b)       } \\\r\n   } }       |\\~   ~/|       { {\r\n  / /        | )   ( |        \\ \\\r\n { {        _)(,   ,)(_        } }\r\n  } }      //  `\";\"`  \\\\      { {\r\n / /      //     (     \\\\      \\ \\\r\n{ {      {(     -=)     )}      } }\r\n \\ \\     /)    -=(=-     (\\    / /\r\n  `\\\\  /'/    /-=|\\-\\    \\`\\  //'\r\n    `\\{  |   ( -===- )   |  }/'\r\n      `  _\\   \\-===-/   /_  '\r\n  jgs   (_(_(_)'-=-'(_)_)_)\r\n        `\"`\"`\"       \"`\"`\"`\r");
            }
            else if (ennemy is Orc)
            {
                Console.WriteLine("     .      .\r\n     |\\____/|\r\n    (\\|----|/)\r\n     \\ 0  0 /\r\n      |    |\r\n   ___/\\../\\____\r\n  /     --       \\\r\n /  \\         /   \\\r\n|    \\___/___/(   |\r\n\\   /|  }{   | \\  )\r\n \\  ||__}{__|  |  |\r\n  \\  |;;;;;;;\\  \\ / \\_______\r\n   \\ /;;;;;;;;| [,,[|======'\r\n     |;;;;;;/ |     /\r\n     ||;;|\\   |\r\n     ||;;/|   /\r\n     \\_|:||__|\r\n      \\ ;||  /\r\n      |= || =|\r\n      |= /\\ =|\r\n      /_/  \\_\\\r");
            }
            else
            {
                Console.WriteLine("                     .\r\n                    / V\\\r\n                  / `  /\r\n                 <<   |\r\n                 /    |\r\n               /      |\r\n             /        |\r\n           /    \\  \\ /\r\n          (      ) | |\r\n  ________|   _/_  | |\r\n<__________\\______)\\__)\r");
            }

        }
       
        private static void BattleStats(Heroes player, Monsters ennemy) 
        {
            Console.WriteLine($"YOU   \t\t\t {ennemy.Name}");
            Console.WriteLine($"HP : {player.Health}  \t\t HP :{ennemy.Health}");
            Console.WriteLine($"Str : {player.Strenght} \t\t Str :{ennemy.Strenght}");
            Console.WriteLine($"Sta : {player.Stamina} \t\t Sta :{ennemy.Stamina}");

        }


        private static void BattleUI(Heroes player, Monsters ennemy, int turn) 
        {
            BattleSprite(ennemy);
            Console.WriteLine();
            Console.WriteLine($"================[TURN {turn}]=============");
            Console.WriteLine();
            BattleStats(player, ennemy);
        }
        
        
        public static void CheckPosition(Heroes player, List<Monsters> EnnemyList, string[,] grille)
        {

            bool battle = false;
            foreach (Monsters monster in EnnemyList)
            {

                
                if ((monster.CoordinateX == player.CoordinateX) && (monster.CoordinateY == player.CoordinateY))
                {
                    Battle(player, monster);
                    battle = true;
                }
                

            }
            if (battle) //là pour reafficher la grille après un combat
            {
                EnnemyList.RemoveAll(Monsters => Monsters.Health <= 0);
                GridSystem.Grid(player, grille, EnnemyList);
            }
        }


        public static void Battle(Heroes player, Monsters ennemy)
        {
            int turn = 1;
            Console.Clear();
            BattleUI(player, ennemy, turn);
            Console.WriteLine($"You encounter a {ennemy.Name}!");
            Console.ReadKey();           
            do
            {
                Console.Clear();
                BattleUI(player, ennemy, turn);
                player.Attack(ennemy);
                Console.ReadKey();
                if(ennemy.Health > 0) 
                { 
                    Console.Clear();
                    BattleUI(player, ennemy, turn);
                    ennemy.Attack(player);
                    Console.ReadKey();
                }
                turn++;
            } while ((ennemy.Health > 0) && (player.Health > 0)); ;



            if (ennemy.Health <= 0)
            {
                Console.Clear();
                BattleUI(player, ennemy, turn);
                Console.WriteLine("You win congratulations !");
                Console.ReadKey();
                player.gold += ennemy.gold;
                player.leather += ennemy.leather;
                Console.Write($"You gain {ennemy.gold} golds");
                Console.WriteLine(ennemy.gold > 0 ? " Nice" : " To bad");
                player.XP += ennemy.XP;
                Console.WriteLine($"You gain {ennemy.XP} points of experience");
                player.Health = player.MahHealth;
                Console.ReadKey();
                Console.Clear();
                player.LvlUp();
            }
            else if (player.Health <= 0)
            {
                Console.Clear();
                BattleUI(player, ennemy, turn);
                Console.WriteLine("You feel something sharp in your guts !");
                Console.WriteLine("...your strenght is abandonning you...");
                Console.ReadKey();
            }

        }




    }
}
