using System;

public class JournalPrompt
{
    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List the places I have been to today.",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why.",
            "What was the most outrageous thing you did today?",
            "What was the best meal of the day today and what was it?",
            "Who made you feel good today?",
            "What did you learn today?",
            "What is the funniest thing that happened today?",
            "If you could become an expert in any subject or activity, what would it be?",
            "What would you buy today if money were no object?",
            "How did you procrastinate on important tasks today?",
            "What scripture just popped into your head right now?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "What steps did you take today towards a goal you’re working on?",
            "How can you make tomorrow (even) better than today?",
            "What went well today?",
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {
    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string JournalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string JournalPrompt = _journalPrompt[index];

        return JournalPrompt;
    }
}