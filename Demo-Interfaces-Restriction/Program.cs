using Demo_Interfaces_Restriction;

Personnage joueur = new Personnage("Arthur");
Personnage cpu = new Personnage("Richard");
joueur.OnHurt += (h) => Console.WriteLine($"{h.Name} a frappé .");
cpu.OnHurt += (h) => Console.WriteLine($"{h.Name} a frappé .");
joueur.OnBeHurt += (h) => Console.WriteLine($"{h.Name} n'a plus que {h.PV}/{h.PVMax}.");
cpu.OnBeHurt += (h) => Console.WriteLine($"{h.Name} n'a plus que {h.PV}/{h.PVMax}.");
joueur.OnDeath += (h) => Console.WriteLine($"{h.Name} est mort...");
cpu.OnDeath += (h) => Console.WriteLine($"{h.Name} est mort...");

IPersoStat heroes = joueur;
IPersoStat monster = cpu; 
Console.WriteLine($"Mon héros se nomme {heroes.Name}.");
Console.WriteLine($"Il combat l'ennemi qui se nomme {monster.Name}.");

IPersoAction c1 = joueur; 
IPersoAction c2 = cpu;
do
{
    c1.Frapper(c2);    
    (c1,c2) = (c2,c1);  //Interversion par les tuples

}while( c2.EstEnVie && c1.EstEnVie);