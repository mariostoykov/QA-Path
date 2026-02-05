
public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song (string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
}

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split('_');
            string typeList = parts[0];
            string name = parts[1];
            string time = parts[2];

            songs.Add(new Song(typeList, name, time));
        }

        string filter = Console.ReadLine();

        foreach (var song in songs)
        {
            if (filter == "all" || song.TypeList == filter)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
