
using System.Security.Cryptography.X509Certificates;

public class Pokemon
{
    public string Name { get; set; }
    public string Element {  get; set; }
    public int Health { get; set; }

    public Pokemon(string name, string element, int health)
    {
        Name = name; 
        Element = element; 
        Health = health;
    }

}


public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        Pokemons = new List<Pokemon>();
    }
}

public class Program
{
    public static void Main()
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        //Input
        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] parts = input.Split(' ');
            string trainerName = parts[0];
            string pokemonName = parts[1];
            string element = parts[2];
            int health = int.Parse(parts[3]);

            Pokemon pokemon = new Pokemon(pokemonName, element, health);

            if (!trainers.ContainsKey(trainerName))
            {
                trainers[trainerName] = new Trainer(trainerName);
            }

            trainers[trainerName].Pokemons.Add(pokemon);
        }

        //Tournament
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p => p.Element == command))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (var p in trainer.Pokemons)
                    {
                        p.Health = -10;
                    }

                    trainer.Pokemons = trainer.Pokemons
                        .Where(p  => p.Health > 0)
                        .ToList();
                }
            }
        }

        //Output
        foreach (var trainer in trainers.Values
                     .OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }

    }
}