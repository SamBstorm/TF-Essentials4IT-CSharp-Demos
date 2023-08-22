using Demo_MultiHeritage;

List<Animal> animals = new List<Animal>();

animals.Add(new PoissonClown("Némo"));
animals.Add(new Sole("Doris"));
animals.Add(new Cheval("Joly Jumper"));
animals.Add(new Loup("Balto"));

foreach (Animal a in animals)
{
    if (a is IHerbivore)
    {
        Console.WriteLine("Mange de la fougère...");
    }
    else
    {
        Console.WriteLine("Fais gaffe à ton doigt!");
    }
}
