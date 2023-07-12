using System;

public class HowToPlay
{
    private string _howToPlay = $@"
    
    How To Play Hangman
    ===============================================
    
    The Game
    
    Hangman is a classic word game in which you have to guess a word
    one letter at a time. At the start of the game, you will be 
    presented with a set of blank lines, which represent the mising
    letters of the secret word. Everytime you guess an incorrect letter,
    another part of the hangman will be drawn on the screen. You need
    to guess the word before he is fully drawn.

    ===============================================
    
    * Guess one letter at a time to reveal part of the word.
    * Each incorrect guess will add another part of the hangman.
    * You will be given 7 incorrect guesses before the game ends.

    ===============================================
    
    --- Press Enter to return to menu ---";

    public void GetInstructions()
    {
        Console.Clear();

        Console.Write(_howToPlay);
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
}