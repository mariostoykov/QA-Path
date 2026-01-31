
string password = Console.ReadLine();

if (!CheckPassBetween6And10Characters(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!CheckPassContainsOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!CheckMinDigitsInPass(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (CheckPassBetween6And10Characters(password) && 
    CheckPassContainsOnlyLettersAndDigits(password) && 
    CheckMinDigitsInPass(password))
{
    Console.WriteLine("Password is valid");
}

static bool CheckPassBetween6And10Characters(string pass)
{
    if (pass.Length >= 6 && pass.Length <= 10)
    {
        return true;
    }

    return false;
}

static bool CheckPassContainsOnlyLettersAndDigits(string pass)
{
    for (int i = 0; i < pass.Length; i++)
    {
        char currChar = pass[i];

        if (!char.IsLetterOrDigit(currChar))
        {
            return false;
        }

    }

        return true;
}

static bool CheckMinDigitsInPass(string pass)
{
    int counter = 0;

    for (int i = 0; i < pass.Length; i++)
    {
        char currChar = pass[i];

        if (char.IsDigit(currChar))
        {
            counter++;

            if (counter >= 2)
            {
                return true;
            }
        }

    }

    return false;
}