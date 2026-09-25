namespace Heroes_VS_Monsters.Classes
{
    public class Dice
    {
        public int chiffre { get; set; }


        public  int Maximun { get; }
        public  int Minumun { get; }


        public Dice(int min, int max) 
        { 
            Maximun = max;
            Minumun = min;
            chiffre = ThrowDice(); 
           
        }
                
        private int ThrowDice() 
        {
            Random alea = new Random();

            return alea.Next(this.Minumun, this.Maximun);
        }
    }
}
