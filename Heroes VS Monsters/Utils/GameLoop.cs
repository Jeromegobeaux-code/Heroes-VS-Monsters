using Heroes_VS_Monsters.Classes;

namespace Heroes_VS_Monsters.Utils
{
    public class GameLoop
    {
       
        public static void TitleScreen() //Menu de lancement du jeu
        {
            Console.WriteLine(" ____  ____                                                     \n|_   ||   _|                                                    \n  | |__| |  .---.  _ .--.   .--.   .---.  .--.                  \n  |  __  | / /__\\\\[ `/'`\\]/ .'`\\ \\/ /__\\\\( (`\\]                 \n _| |  | |_| \\__., | |    | \\__. || \\__., `'.'.                 \n|____||____|'.__.'[___]    '.__.'  '.__.'[\\__) )                \n                ____   ____   ______                            \n               |_  _| |_  _|.' ____ \\                           \n                 \\ \\   / /  | (___ \\_|                          \n                  \\ \\ / /    _.____`.                           \n                   \\ ' /    | \\____) |                          \n ____    ____       \\_/      \\______.'_                         \n|_   \\  /   _|                       / |_                       \n  |   \\/   |   .--.   _ .--.   .--. `| |-'.---.  _ .--.  .--.   \n  | |\\  /| | / .'`\\ \\[ `.-. | ( (`\\] | | / /__\\\\[ `/'`\\]( (`\\]  \n _| |_\\/_| |_| \\__. | | | | |  `'.'. | |,| \\__., | |     `'.'.  \n|_____||_____|'.__.' [___||__][\\__) )\\__/ '.__.'[___]   [\\__) ) \n                                                                ");
            Console.WriteLine("\nPresse any key to start");
            Console.WriteLine("V 1.0");
            Console.ReadKey(true);
        }


        public static void GameOver(Heroes player) //Fonction quand le joueur a 0 PV
        {
            Console.Clear();
            Console.WriteLine("                  _  /)\r\n                 mo / )\r\n                 |/)\\)\r\n                  /\\_\r\n                  \\__|=\r\n                 (    )\r\n                 __)(__\r\n           _____/      \\\\_____\r\n          |  _     ___   _   ||\r\n          | | \\     |   | \\  ||\r\n          | |  |    |   |  | ||\r\n          | |_/     |   |_/  ||\r\n          | | \\     |   |    ||\r\n          | |  \\    |   |    ||\r\n          | |   \\. _|_. | .  ||\r\n          |                  ||\r\n          |  name goes here  ||\r\n          |                  ||\r\n  *       | *   **    * **   |**      **\r\n   \\))ejm97/.,(//,,..,,\\||(,,.,\\\\,.((//");
            Console.WriteLine($"\nYou've been slain\n" +
                $"{player.Name}, during your adventure you won {player.gold}G that's great. To bad you died\n" +
                $"Anyways, wanna play again ?");
            Console.ReadKey(true);
        }


        public static void Victory(Heroes player) //Fontion qui se lance dés lors que le joueur a vaincu tout les monstres
        {
            Console.Clear();
            Console.WriteLine("        _\r\n       (_)\r\n       |=|\r\n       |=|\r\n   /|__|_|__|\\\r\n  (    ( )    )\r\n   \\|\\/\\\"/\\/|/\r\n     |  Y  |\r\n     |  |  |\r\n     |  |  |\r\n    _|  |  |\r\n __/ |  |  |\\\r\n/  \\ |  |  |  \\\r\n   __|  |  |   |\r\n/\\/  |  |  |   |\\\r\n <   +\\ |  |\\ />  \\\r\n  >   + \\  | LJ    |\r\n        + \\|+  \\  < \\\r\n  (O)      +    |    )\r\n   |             \\  /\\ \r\n ( | )   (o)      \\/  )\r\n_\\\\|//__( | )______)_/ \r\n        \\\\|//        \r\n");
            Console.WriteLine($"All the monsters are dead, congratulation {player.Name}\n" +
            $"With this quest you made {player.gold}G not bad\n" +
            "But deep down you wonder, aren't you the true monster after this bloodbath\n\n" +
            "Anyways, wanna play again ?");
            Console.ReadKey(true);

        }

    }
}
