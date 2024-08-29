

static string[] MakeUnderscores(string word)
{
    string[] underscores = new string[word.Length];

    for (int i = 0; i < underscores.Length; i++)
    {
        underscores[i] = "_";
    }

    return underscores;
}



Random r = new Random();
string[] words = {"security","nest","solo","account","broken","innocent","manufacturer","provoke","lily","finished"};

string word = words[r.Next(words.Length)].ToUpper();
List<string> wrongGuesses = new();

string[] hiddenWord = MakeUnderscores(word);

Console.WriteLine("hangman...");
Console.WriteLine("\nletter...now");

int lives = 10;
while (wrongGuesses.Count < lives && string.Join("", hiddenWord) != word)
{

Console.WriteLine(string.Join(" ", hiddenWord));
string guess = Console.ReadLine().ToUpper();

while (guess.Length == 0)
{
    Console.Clear();
    Console.WriteLine("Input a valid letter");
    guess = Console.ReadLine().ToUpper();
}

if(word.Contains(guess[0]))
{
    Console.Clear();
    Console.WriteLine($"wowie\nLives:{lives-wrongGuesses.Count - 1}");
    wrongGuesses.ForEach(Console.WriteLine);

    for (int i = 0; i < word.Length; i++)
    {
        if(word[i] == guess[0])
        {
            hiddenWord[i] = guess[0].ToString();
        }
    }

}
else
{
    Console.Clear();
    Console.WriteLine($"shit\nlives:{lives-wrongGuesses.Count - 1}");
    wrongGuesses.Add(guess);
    wrongGuesses.ForEach(Console.WriteLine);
}



}


if (wrongGuesses.Count == lives)
{
    Console.Clear();
    Console.WriteLine("Game over, lost");
    Console.WriteLine($"the word was {word}");
    Console.ReadLine();
}
else if(string.Join("", hiddenWord) == word)
{
    Console.Clear();
    Console.WriteLine(word);
    Console.WriteLine("\nWin yay!");
    Console.ReadLine();
}
