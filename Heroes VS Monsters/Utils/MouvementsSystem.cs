using heroes_vs_monsters.classes;
using Heroes_VS_Monsters.Classes;
using System;


namespace Heroes_VS_Monsters.Utils
{
    internal class MouvementsSystem
    {


        public static void Movements(Heroes Player, string[,] grille) //Permet de choisir la direction dans laquelle se déplacer
        {
            
            

                       
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    if (Player.CoordinateY != 0) { Player.CoordinateY--; }
                    else { Console.WriteLine("a magical force stop you for going there"); }
                    break;

                case ConsoleKey.LeftArrow:
                    if (Player.CoordinateX != 0) { Player.CoordinateX--; }
                    else { Console.WriteLine("a magical force stop you for going there"); Console.ReadKey(); }
                    break;

                case ConsoleKey.DownArrow:
                    if (Player.CoordinateY != grille.GetLength(0) - 1) { Player.CoordinateY++; }
                    else { Console.WriteLine("a magical force stop you for going there"); Console.ReadKey(); }
                    break;

                case ConsoleKey.RightArrow:
                    if (Player.CoordinateX != grille.GetLength(1) - 1) { Player.CoordinateX++; }
                    else { Console.WriteLine("a magical force stop you for going there"); Console.ReadKey(); }
                    break;

                default:
                    break;
            }
            
        }

        public static void UpDatePosition(Heroes Player) 
        {

            Console.WriteLine("test");


        }



    }
}

