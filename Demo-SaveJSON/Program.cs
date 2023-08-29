using Demo_SaveJSON;
using System.Text.Json;


//Création de mes objets
List<Person> profs = new List<Person>();

Person p1 = new Person()
{
    firstname = "Samuel",
    lastname = "Legrain",
    birthdate = new DateTime(1987, 9, 27)
};

Person p2 = new Person()
{
    firstname = "Alexandre",
    lastname = "Claes",
    birthdate = new DateTime(1987, 9, 27)
};

profs.Add(p1);
profs.Add(p2);


//Convertion objects => text format JSON
string json_result = JsonSerializer.Serialize(profs);
Console.WriteLine(json_result);

//Sauvegarde du text sur fichier
//Définition du chemin d'accès au fichier
DirectoryInfo cDirs = Directory.CreateDirectory(@"c:\Save\Test");

//Définition du fichier à l'aide du stream writer
using (StreamWriter sw = new StreamWriter($"{cDirs.FullName}\\save.json"))
{
    sw.WriteLine(json_result);
}

//Relecture du fichier
string save_json;
using (StreamReader sr = new StreamReader($"{cDirs.FullName}\\save.json"))
{
    save_json = sr.ReadToEnd();
}

//Convertion text format JSON => objects

List<Person> convert_result = JsonSerializer.Deserialize<List<Person>>(save_json);

foreach (Person p in convert_result)
{
    Console.WriteLine($"{p.firstname} , {p.lastname}");
}