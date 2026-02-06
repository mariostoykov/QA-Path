
using System.ComponentModel;

int n = int.Parse(Console.ReadLine());
Dictionary<string, string> parkingList  = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] parts = Console.ReadLine().Split();
    string command = parts[0];
    string username = parts[1];

    if (command == "register")
    {
        string licensePlate = parts[2];

        if (parkingList.ContainsKey(licensePlate))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parkingList[username]}");
        }
        else
        {
            parkingList[username] = licensePlate;
            Console.WriteLine($"{username} registered {licensePlate} successfully");
        }
    }
    else if (command == "unregister")
    {
        if (!parkingList.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parkingList.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}

foreach (var entry in parkingList)
{
    Console.WriteLine($"{entry.Key} => {entry.Value}");
}