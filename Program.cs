namespace besenica
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var playWords = new List<string>();
            playWords.Add("ibrahim");
            playWords.Add("yovcho");
			playWords.Add("banan");
			playWords.Add("ventilator");

            string gameWord = playWords[new Random().Next(0, playWords.Count)];

            var listOfChars = gameWord.ToCharArray();
            var listOfWrongLettersGuessed = new List<char>();
            int countOfFails = 0;
            Dictionary<char, List<int>> guessedLetters = new Dictionary<char, List<int>>();

            Console.WriteLine("Enter a letter a-z");
            while (true)
            {
                PrintGuessedLetters(guessedLetters);
                PrintEmptyDashes(gameWord);
                Hangman.PrintHangman(countOfFails);
                char pressed = (Console.ReadKey().KeyChar);

                if (pressed >= 'a' && pressed <= 'z')
                {
                    if (listOfChars.Contains(pressed))
                    {
                        List<int> addingLetters = new List<int>();

                        for (int i = 0; i < listOfChars.Length; i++)
                        {
                            if (listOfChars[i] == pressed)
                            {
                                addingLetters.Add(i);
                            }
                        }
                        try
                        {
                            guessedLetters.Add(pressed, addingLetters);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Veche q napisahme tazi bukva ve shtarkel");
                        }
                        
                    }
                    else if (listOfWrongLettersGuessed.Contains(pressed))
                    {
                        Console.WriteLine("Veche q probva taq bukva i ne stana, baven li si?");
                    }
                    else
                    {
                        listOfWrongLettersGuessed.Add(pressed);
                        countOfFails++;
                        if (countOfFails > 8)
                        {
                            Console.WriteLine("you lost the game");
                            return;
                        }
                    }
                }
                
            }
        }
        static void PrintEmptyDashes(string word)
        {
            Console.SetCursorPosition(53, 25);
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
        }
        static void PrintGuessedLetters(Dictionary<char, List<int>> guessedLetters)
        {
            
            int x = 53;
            foreach (var item in guessedLetters)
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.SetCursorPosition(item.Value[i]*2 + x, 24);
                    Console.Write(item.Key);
                }
            }
        }
    }
}