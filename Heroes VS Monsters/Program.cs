#region TO DO LIST
#region Classes

//Créer une classe personnage globale avec les infos commues aux monstres et héros
//Faire attention a ses contraintes
//La force et l’endurance sont des propriétés en lecture seule
//La propriété PV est « private » aussi bien en lecture et en écriture.
//Les bonus d’endurance et de force offerts par les classes (Humain, Nain, Orque et Dragonnet)
//ne doivent pas modifier la caractéristique de base du personnage

//Dans la classe personnage, créer une méthode abstract pour la mort du personnage. Elle doit check les PV du personnage
//chez les héros, faire en sorte que cela lance une méthode GAME OVER quand HP = 0
//chez les monstres, faire en sorter que le monstre disparaisse et donne son loot au héro
//Créer le sysyème de bonus selon le type de perso
//Faire une méthode qui assigne des stats aux personnages :
// Pour chaque stat; Il faut lancer 4 dés à 6 faces --> créer 4 randoms qui vont de 1 à 6
// Il faut garder que les 3 meilleurs résultats pour assigner les aux stats


#endregion

#region Créer son perso et combattre
//Permettre à l'user de créer son propre personnage en choissisant sa classe et son nom
//Créer le système de combat ou le héros peut frapper l'ennemi. Le combat se finit quand un perso a 0 PV
//Compléxifier le système de combat en s'inspirant du pierre feuille sciseaux :

//  - Attaquer > Magie
//  - Parer > Attaquer
//  - Magie > Parer
#endregion

#region Deplacement
//Créer une système pour afficher et se déplacer sur un tableau à deux dimensions
//Créer un système qui assigne un nombre définit de monstres à des endroits alléatoires du tableau
//Afficher la quantité d'or et de cuir gagnée ainsi que le nombre d'ennemi restant à vaincre 
//Créer un système qui lance un combat quand le héros et côte à côte avec un monstre
#endregion
#endregion

using Heroes_VS_Monsters.Classes;
using Heroes_VS_Monsters.Utils;
using System;
using System.Numerics;

Console.OutputEncoding = System.Text.Encoding.UTF8;
GameLoop.TitleScreen();
Heroes Player = CharactersSystem.ClasseSelection();


Console.WriteLine("welcome to the forest of Cèverissi. Slain all the mosnters for glory");
Console.ReadKey(true);


MonstersManagement manager = new MonstersManagement();
manager.Spawning(Player);
string[,] grille = new string[15, 15];


    GridSystem.Grid(Player, grille, manager.monstres);

do
{

    GridSystem.Grid(Player, grille, manager.monstres);//a supprimer dés que j'arrive à juste refresh le pion du joueur

    MouvementsSystem.Movements(Player, grille);

    BattleSystem.CheckPosition(Player, manager.monstres, grille);


} while((Player.Health > 0)&&(manager.monstres.Count>0));


if(Player.Health <= 0) 
{ 
    GameLoop.GameOver(Player);
}
else 
{ 
    GameLoop.Victory(Player);
}






//a faire  : - ne pas avoir un console clear après chaque deplacement et juste changer la position du pion du joueur
//           - Console.cursor devrait m'aider, je dois trouver comment l'utiliser...