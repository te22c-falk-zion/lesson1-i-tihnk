

static string[] MakeUnderscores(string word)
{
    string[] underscores = new string[word.Length];

    for (int i = 0; i < underscores.Length; i++)
    {
        underscores[i] = "_";
    }

    return underscores;
}



string word = "LIMBUS COMPANY";
List<string> wrongGuesses = new();

string[] hiddenWord = MakeUnderscores(word);

Console.WriteLine("hangman...");
Console.WriteLine("\nletter...now");

int lives = 5;
while (wrongGuesses.Count < lives && string.Join("", hiddenWord) != word)
{

Console.WriteLine(string.Join(" ", hiddenWord));
string guess = Console.ReadLine().ToUpper();

if(word.Contains(guess[0]))
{
    Console.WriteLine("wowie");

    for (int i = 0; i < word.Length; i++)
    {
        if(word[i] == guess[0])
        {
            hiddenWord[i] = guess;
        }
    }

//     int pos = word.IndexOf(guess[0]);
//     hiddenWord[pos] = guess;
}
else
{
    Console.WriteLine("shit");
    wrongGuesses.Add(guess);
}
}

Console.WriteLine("\ndone");
Console.ReadLine();