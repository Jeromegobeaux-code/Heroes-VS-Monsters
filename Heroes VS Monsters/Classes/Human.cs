namespace Heroes_VS_Monsters.Classes
{
    public class Human : Heroes
    {

        int bonus { get; set; } = 1;

        public Human(string name) : base(name)
        {
            this.Jeton = "H";
        }

    }
}
