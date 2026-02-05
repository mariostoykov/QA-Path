
public class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }
}

public class Program
{
    public static void Main()
    {
        int teamCount = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        // Creating Teams
        for (int i = 0; i < teamCount; i++)
        {
            string[] teamInput = Console.ReadLine().Split('-');
            string creator = teamInput[0];
            string teamName = teamInput[1];

            // Check if team name already exists
            if (teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }

            // Check if the user already created a team
            else if (teams.Any(t => t.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }

            else
            {
                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }

        // User Join Commands
        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] joinInput = command.Split("->");
            string user = joinInput[0];
            string teamToJoin = joinInput[1];

            Team team = teams.FirstOrDefault(t => t.Name == teamToJoin);


            // Teams must exist
            if (team == null)
            {
                Console.WriteLine($"Team {teamToJoin} does not exist!");
                continue;
            }

            // Check if user is already in a team (as member or creator)
            bool isinAnyTeam = teams.Any(t => t.Creator == user || t.Members.Contains(user));

            if (isinAnyTeam)
            {
                Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
            }
            else
            {
                team.Members.Add(user);
            }
        }

        // Output
        var validTeams = teams
            .Where(t => t.Members.Count > 0)
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name);

        var disbandTeams = teams
            .Where(t => t.Members.Count == 0)
            .OrderBy(t => t.Name);

        // Print valid teams
        foreach (var team in validTeams)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        // Print disbanded teams
        Console.WriteLine("Teams to disband:");
        foreach (var team in disbandTeams)
        {
            Console.WriteLine(team.Name);
        }
    }
}