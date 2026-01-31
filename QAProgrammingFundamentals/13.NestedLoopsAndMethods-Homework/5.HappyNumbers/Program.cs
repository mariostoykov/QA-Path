// Лектора казва, че 5та е подобна на 3та//

int N = int.Parse(Console.ReadLine());

for (int d1 = 1; d1 <= N; d1++)
{
    for (int d2 = 0; d2 <= N; d2++)
    {      
        for (int d3 = 0; d3 <= N; d3++)
        {
            for (int d4 = 0; d4 <= N; d4++)
            {
                if (d1 + d2 == N && d3 + d4 == N)
                {
                   Console.WriteLine($"{d1}{d2}{d3}{d4}");
                }
            }
        }
    }
}