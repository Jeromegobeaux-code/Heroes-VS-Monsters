using heroes_vs_monsters.classes;
using Heroes_VS_Monsters.Classes;


namespace Heroes_VS_Monsters.Utils
{

    public class MonstersManagement //classe me permettant de gerer ma liste de monstres et de choisir leur position
    {
        
        
        //repenser mon systeme de creation de monstres ce que j'ai fait ne marche évidemment pas ptdr
        //revoir indexeur
        
        
        public List<Monsters> monstres = new List<Monsters>
        {
            new Dragon(),

            new Dragon(),
            
            new Wolf(),
            
            new Wolf(),
            
            new Wolf(),

            new Wolf(),
            
            new Orc(),
            
            new Orc(),

            new Orc(),

        };

        
        public void Spawning(Heroes Player) 
        { 
        
            foreach(Monsters monster in monstres) 
            {
                do
                {

                monster.CoordinateX = new Dice(0, 15).chiffre;
                monster.CoordinateY = new Dice(0, 15).chiffre;

                }while((monster.CoordinateY == Player.CoordinateY)||(monster.CoordinateX == Player.CoordinateX)
                ||(monster.CoordinateY == Player.CoordinateY+1) || (monster.CoordinateX == Player.CoordinateX+1));

            }

            //foreach (Orc orc in monstres)
            //{
            //    grille[orc.coordinatex, orc.coordinatey] = 'o';
            //}

            //foreach (Wolf wolf in monstres)
            //{
            //    grille[wolf.coordinatex, wolf.coordinatey] = 'w';
            //}

            //foreach (Dragon drag in monstres)
            //{
            //    grille[drag.coordinatex, drag.coordinatey] = 'w';
            //}


        }


        //lancer un dé 15 pour la position x et y de chaque monstre
        // si = a heroes.x ou heroes.y OU heroes.x+1 ou heroes.y+1; relancer les dés jusqu'à résultat 
        // trouver comment gérer si joueur est à côté de deux monstres en même temps ? (enchainer les deux combats successivement ?)
    }
}
