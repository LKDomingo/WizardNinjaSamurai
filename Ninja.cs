class Ninja : Human
{
    public Ninja(string name) : base(name)
    {
        Dexterity = 175;
    }

    public override int Attack(Human target)
    {
        Random rand = new Random();

        target.Health -= 5*this.Dexterity;
        if(rand.Next(4) == 0){
            target.Health -= 10;
        }
        return target.Health;
    }

    public int Steal(Human target) 
    {
        target.Health -= 5;
        this.Health += 5;

        return target.Health;
    }
}