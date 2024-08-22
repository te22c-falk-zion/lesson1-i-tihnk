

string word = "gooning";

string[] hiddenWord = {"_", "_","_","_","_","_","_"};

Console.WriteLine("hangman...");

foreach (string letter in hiddenWord)
{
    Console.Write(letter);
}

Console.WriteLine("\nletter...now");

while (true)
{
string guess = Console.ReadLine();


if(word.Contains(guess[0]))
{
    Console.WriteLine("wowie");
}
else
{
    Console.WriteLine("shit");
}
}