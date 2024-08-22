

string word = "gooning";

string[] hiddenWord = {"_", "_","_","_","_","_","_"};

Console.WriteLine("hangman...");

foreach (string letter in hiddenWord)
{
    Console.Write(letter);
}

Console.WriteLine("\nletter...now");

Console.ReadLine();