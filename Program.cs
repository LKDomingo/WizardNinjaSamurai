Human Steve = new Human("Steve");
Wizard Merlin = new Wizard("Merlin");
Ninja Goemon = new Ninja("Goemon");
Samurai Afro = new Samurai("Afro");

Console.WriteLine(Merlin.Attack(Steve));
Console.WriteLine(Merlin.Heal(Steve));
Console.WriteLine(Goemon.Attack(Steve));
Console.WriteLine(Goemon.Steal(Steve));
Console.WriteLine(Merlin.Heal(Steve));
Console.WriteLine(Afro.Attack(Steve));
Console.WriteLine(Merlin.Attack(Afro));
Console.WriteLine(Afro.Meditate());

