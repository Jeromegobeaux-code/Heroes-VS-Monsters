namespace Heroes_VS_Monsters.Classes
{
    
    public abstract class Heroes : Characters
    {
            

        public Heroes(string name = "Player") : base()
        {
            gold = 0;
            this.Name = name;
            CoordinateX = position();
            CoordinateY = position();
            Jeton = "H";
        }

        public int position() 
        { 
            Random position = new Random();
            return position.Next(0, 15);
        
        }

        public int Level = 1;

        public int XP = 0;

        public void LvlUp() 
        { 
        
            if(XP >= 10) 
            { 
                XP = 0;
                Level += 1;
                Console.WriteLine("Level UP !");
                Console.WriteLine("You feel a new power awakens in you...\nChoose a stat to improve !\n1.Strenght\n2.Stamina");
                int choice;
                bool bChoice;
                do
                {
                    bChoice = int.TryParse(Console.ReadLine(), out choice);
                } while ((!bChoice)||(choice > 2)&&(choice < 1));
                
                switch(choice) 
                {
                    case 1:
                        Strenght += 1;
                        break;
                    case 2:
                        Stamina +=1;
                        break;
                
                }

                //faire menu choix de stat à améliorer
                //faire que perso gagne un D3 d'XP après chaque combat
                //ajouter à chaque perso un spécial (et un system de mp pour l'utiliser ?)
                //special humain : 
                //special nain : dégâts/2
                //special elfe : attaque avec 2 D5
                //special mage : lance 1D6; fait un sort selon résultat
            }
        
        }

        //ajouter un système d'exp ? quand x ennemis tuer proposer d'ajouter un pt en stamina ou force ?

    }
}
