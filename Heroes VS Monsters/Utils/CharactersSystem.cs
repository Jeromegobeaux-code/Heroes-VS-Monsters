using Heroes_VS_Monsters.Classes;

namespace Heroes_VS_Monsters.Utils
{
    internal class CharactersSystem
    {

        public static Heroes ClasseSelection() //Fonction pour choisir sa classe (! ameliorer menu choix ?)
        {
            Console.Clear();
            int choice = 0;
            bool Bchoice = false;


            Console.WriteLine("           .-----.\r\n \\ ' /   _/    )/\r\n- ( ) -('---''--)\r\n / . \\((()\\^_^/)()\r\n  \\\\_\\ (()_)-((()()\r\n   '- \\ )/\\._./(()\r\n     '/\\/( X   ) \\\r\n     (___)|___/ ) \\\r\n          |.#_|(___)\r\n         /\\    \\ ( (_\r\n         \\/\\/\\/\\) \\\\\r\n         | / \\ |\r\n         |(   \\|\r\n        _|_)__|_\\_\r\n        )...()...(\r\n         | (   \\ |     \r\n      .-'__,)  (  \\\r\n  mrf           '\\_-,\r");
            Console.WriteLine("\n ===================================================");

            Console.WriteLine("What's your name brave Hero ?");
            string nomHero = Console.ReadLine()!;

            nomHero = nomHero=="" ? "Hero" : nomHero;

            Heroes player;
            Console.WriteLine($"I see... so you're name is {nomHero}... Verry interesting..." );
            Console.WriteLine("My eyes are not what they used to be... So tell me, to which people do you belong ?\n" +
                "1. Humankind- bonus in strenght and stamina\n2. Dwarves- big bonnus in stamina\n" +
                "3. Elves - less dammages but attack twice\n4. Magus - charge their mana for devasting effect");
   
            do
            {
                Bchoice = int.TryParse(Console.ReadLine(), out choice);
            } while ((!Bchoice) || ((choice < 1) || (choice > 4)));


            Console.Clear() ;
            Console.WriteLine("           .-----.\r\n \\ ' /   _/    )/\r\n- ( ) -('---''--)\r\n / . \\((()\\^_^/)()\r\n  \\\\_\\ (()_)-((()()\r\n   '- \\ )/\\._./(()\r\n     '/\\/( X   ) \\\r\n     (___)|___/ ) \\\r\n          |.#_|(___)\r\n         /\\    \\ ( (_\r\n         \\/\\/\\/\\) \\\\\r\n         | / \\ |\r\n         |(   \\|\r\n        _|_)__|_\\_\r\n        )...()...(\r\n         | (   \\ |     \r\n      .-'__,)  (  \\\r\n  mrf           '\\_-,\r");
            Console.WriteLine("\n ===================================================");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ho I see, so you are one of thoses ambitious human");

                    player = new Human(nomHero);
                    return player;
                    
                case 2:
                    Console.WriteLine("Ho so you are a member of the proud people of the North");
                    player = new Dwarf(nomHero);
                    return player;

                case 3:
                    Console.WriteLine("It's me been so long since I saw one of your kind, it's so nostalgic.");
                    player = new Elf(nomHero);
                    return player;

                default:
                    Console.WriteLine("Hoo I see, you're also a student of the arcanes. interesting...");
                    player = new Magus(nomHero);
                    return player;

            }

        }

        public static int StatAtrribution()//Fonction utiliser lors de l'assignation de statistiques au player
        {

            //création des dés qui créeront les valeur randoms assignées aux stats

            Dice d1 = new Dice(1, 7);
            Dice d2 = new Dice(1, 7);
            Dice d3 = new Dice(1, 7);
            Dice d4 = new Dice(1, 7);

            List<int> list = new List<int> { d1.chiffre, d2.chiffre, d3.chiffre, d4.chiffre };

            list.Sort();

            //recup la valeur des 3 premier de la liste et les additionner
            //afficher les valeur avant des stats du perso ?

            return list[3] + list[1] + list[2];

        }
        //creer mes fonctions qui utilisent la classe dé pour assigner des stats et l'appellée dans makeNewHero

    }
}
