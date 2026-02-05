
double[] nums = Console.ReadLine()
        .Split(' ')
        .Select(double.Parse)
        .ToArray();

SortedDictionary<double, int> count = new SortedDictionary<double, int>();

foreach (double num in nums)
{

    if (count.ContainsKey(num))
    {
        count[num]++;
    }
    else
    {
        count[num] = 1;
    }
}
foreach (KeyValuePair<double, int> numpair in count)
{
    Console.WriteLine($"{numpair.Key} -> {numpair.Value}");
}




