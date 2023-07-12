using System;

public class GameMenu : Menu
{
    private new string _menu = $@"
    
    Game Options
    =========================================
    Choose a game mode:
    
    1. Random Words
    2. Pick your word topic

    3. Back to Main Menu
    =========================================
    Please select an option from the menu:  ";

    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu listMenu = new ListMenu();

        while (_action != 3)
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:

                    _wordFileName = "words2.txt"
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                
                case 2:

                    Console.Clear();
                    listMenu.MenuChoice();
                    break;
                
                case 3: 

                    Console.Clear();
                    break;
                
                default:
                    Console.WriteLine($"\nSorry, the option you entered is invalid.");
                    break;
            }
        }
    }
}