using Demo_Event;

Poisson nemo = new Poisson("Némo");
nemo.OnDeath += OnDeathConsole;
do
{
    Console.WriteLine($"{nemo.Name} est toujours là!");
    nemo.Vieillir();
} while (nemo.EstEnVie);
nemo.Vieillir();

void OnDeathConsole(Poisson poisson)
{
    poisson.OnDeath -= OnDeathConsole;
    Console.WriteLine($"Oups... A plus {poisson.Name}");
}