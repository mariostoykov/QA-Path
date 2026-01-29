
string architecturesName = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

int hoursPerProject = 3;
int totalProjectHours = projects * hoursPerProject;

Console.WriteLine($"The architect {architecturesName} will need {totalProjectHours} hours to complete {projects} project/s");

