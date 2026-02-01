
int[] firstArray = Console.ReadLine().
                            Split(" ").
                            Select(int.Parse).
                            ToArray();
int[] secondArray = Console.ReadLine().
                            Split(" ").
                            Select(int.Parse).
                            ToArray();

foreach (int element in firstArray)
{
    if (secondArray.Contains(element))
        Console.Write(element + " "); 
}