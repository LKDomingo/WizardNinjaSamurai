class Wizard : Human
{
    public Wizard(string name) : base (name)
    {
        Health = 50;
        Intelligence = 25;
    }

    public override int Attack(Human target)
    {
        target.Health -= 5*this.Intelligence;
        this.Health += 5*this.Intelligence;
        return target.Health;
    }

    public int Heal(Human target)
    {
        target.Health += 10*this.Intelligence;
        return target.Health;
    }
}