using System;

public class MainMenu : Menu
{
    private new string _menu = $@"
    Main Menu Options
    =========================================
    Please pcik one of the following options:
    
    1. Play Game
    2. How to Play
    3. Quit
    
    =========================================
    Choose an option from the menu:  ";

    private string _welcome = @"
    =========================================
    ---                                   ---
    ***        Welcome to Hangman         ***
    ---                                   ---
    =========================================";
    private string _goodbye = @"
    =========================================
    ---                                   ---
    ***        Thanks for playing         ***
    ---                                   ---
    =========================================";

    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu gameMenu = new GameMenu();
        PrintWelcome();

        while (_action != 3)
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:

                    Console.Clear();
                    gameMenu.MenuChoice();
                    break;
                
                case 2:

                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;

                case 3:

                    PrintGoodbye();
                    break;
                
                default:
                    Console.WriteLine($"\nSorry, the option you entered is invalid.");
                    break;
            }
        }
    }
    private void PrintWelcome()
    {
        Console.Clear();
        Console.Write($"{_welcome}\n\n");
    }
    private void PrintGoodbye()
    {
        Console.Clear();
        Console.Write($"{_goodbye}\n\n");
    }
}