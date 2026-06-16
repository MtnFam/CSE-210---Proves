using System;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO.Compression;

class Listing : Activity
{
    // Variables and Initialization
    private List<string> _prompt = new List<string>() {"Who are the peoaple that you appreciate?", "What are personal strengths of yours?", "Whoa are peopeal that you have halped this week?", "When have you felt the Holy Ghost today?", "Who are your personal heroes?"};
    private int _promptDisp;
    private List<string> response = new List<string>();
    private string _promptChosen;
    private int _time;


    public Listing(int times) : base (int )
    {
        _time = times * 1000;
    }
    public int DisplayPrompt(int number=null)
    {
        if (NumberFormatInfo != null)
        {
            string _promptStr = _prompt[number];
            _promptChosen = _promptStr;
            Console.WriteLine(_promptStr);
            return number;
        }
        else
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _prompt.Count);
            string _promptStr = _prompt[number];
            _promptChosen = _promptStr;
            Console.WriteLine(_promptStr);
        }
    }

    // Method
    public void GetInput()
    {
        Console.Clear;
        
        string _userResponse = Console.ReadLine();
        response.Add(_userResponse);
    }
    public void DisplayAll()
    {
        Console.WriteLine(_promptChosen + "\nResponses");
        foreach (string i in response)
        {
            Console.WriteLine(i);
        }

    }
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        _promptDisp = DisplayPrompt();
        while (startTime < endTime)
        {
            Console.Clear;
            DisplayPrompt(number);
            GetInput();
            startTime = DateTime.Now;
        }
        DisplayAll();
    }

}