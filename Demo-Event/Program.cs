using Demo_Event;


Action<Poisson> OnDeathConsole = (Poisson poisson) => Console.WriteLine($"Oups... A plus {poisson.Name}");


/*delegate(Poisson poisson) {
Console.WriteLine($"Oups... A plus {poisson.Name}");
};*/

Poisson nemo = new Poisson("Némo");
nemo.OnDeath += OnDeathConsole;
nemo.OnDeath += (Poisson p) => p.OnDeath -= OnDeathConsole;
do
{
    Console.WriteLine($"{nemo.Name} est toujours là!");
    nemo.Vieillir();
} while (nemo.EstEnVie);
nemo.Vieillir();


//delegate void ActionSurPoisson(Poisson p);