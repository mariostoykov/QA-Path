
while (true)
{
    string word = Console.ReadLine();

    if (word == "end")
    {
        break;
    }

    char[] reversedArray = word.ToCharArray();
    Array.Reverse(reversedArray);
    string reversedWord = new string(reversedArray);


    Console.WriteLine($"{word} = {reversedWord}");
}