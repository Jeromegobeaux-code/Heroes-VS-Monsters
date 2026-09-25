using heroes_vs_monsters.classes;
using Heroes_VS_Monsters.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Utils
{
    public class GridSystem
    {
       
        public static void Grid(Heroes Player, string[,] grille, List<Monsters> Ennemys) 
        {

            Console.Clear();
            SetGrid(Player, grille, Ennemys);
            ShowGrid(Player, grille);
        
        }
        
        
        
        public static void SetGrid(Heroes Player, string[,] grille, List<Monsters> Ennemys) //place les elements sur la grille
        {

            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    grille[i, j] = ".";
                }
            }
            grille[Player.CoordinateY, Player.CoordinateX] = Player.Jeton;

            foreach (Monsters monsters in Ennemys)
            {

                grille[monsters.CoordinateY, monsters.CoordinateX] = monsters.Jeton;

            }


        }


        public static void ShowGrid(Heroes Player, string[,] grille) //permet d'afficher la grille et gérer la couleur des elements
        {
           
            Console.WriteLine("  Forest of Cèverissi");
            Console.WriteLine(" =================================");
            for (int i = 0; i < grille.GetLength(0); i++)
            {

                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (j == 0) { Console.Write(" | "); }
                    if (grille[i, j] == Player.Jeton)
                    {
                        Console.Write(grille[i, j] + " ", Console.ForegroundColor = ConsoleColor.Cyan);
                    }
                    else if ((grille[i, j] == "O") || (grille[i, j] == "W") || (grille[i, j] == "D"))
                    {
                        Console.Write(grille[i, j] + " ", Console.ForegroundColor = ConsoleColor.Red);
                    }
                    else
                    {
                        Console.Write(grille[i, j] + " ", Console.ForegroundColor = ConsoleColor.DarkGreen);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    if (j == grille.GetLength(1)-1) { Console.Write("|"); }
                }
                switch (i)//vient afficher les stats à côté de la MAP au bon endroit
                {
                    
                    case 0:
                        Console.Write($"\t  _________");
                        break;
                    case 2:
                        Console.Write($"\t| Name {Player.Name} Lvl {Player.Level}");
                        break;
                    case 4:
                        Console.Write($"\t| HP {Player.Health}   XP {Player.XP}/10");
                        break;
                    case 6:
                        Console.Write($"\t| Str {Player.Strenght}");
                        break;
                    case 8:
                        Console.Write($"\t| Sta {Player.Stamina}");
                        break;
                    case 10:
                        Console.Write($"\t| Gold {Player.gold}G", Console.ForegroundColor = ConsoleColor.DarkYellow);
                        break;
                    case 12:
                        Console.Write($"\t| Leahter {Player.leather}", Console.ForegroundColor = ConsoleColor.Magenta);
                        break;
                    case 14:
                        Console.Write($"\t| _________");
                        break;
                }
                Console.WriteLine();
            }
                Console.WriteLine(" =================================");
            
            Console.WriteLine($"\n Wich way do youy want to go {Player.Name} ?");
            Console.WriteLine(" Up : north, Left : west; Right : east, Down : South");
        }
    }
}

