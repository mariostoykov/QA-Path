
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    for (int j = 1; j <= number; j++)
    {
        for (int k = 1; k <= number; k++)
        {
            if (i >= 10 ||  j >= 10 || k >= 10)
            {
                continue;
            }
        
            int product = i * j * k;
            
            if (product == number)
            {
                Console.Write($"{i}{j}{k} ");
            }
         
        }
        
    }
}