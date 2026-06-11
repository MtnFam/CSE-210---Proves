using System;
using System.Dynamic;
using System.Globalization;
using System.IO.Compression;

class Listing
{
    // Variables and Initialization
    private List<string> _prompt = new List<string>() {"Who are the peoaple that you appreciate?", "What are personal strengths of yours?", "Whoa are peopeal that you have halped this week?", "When have you felt the Holy Ghost today?", "Who are your personal heroes?"};
    private List<string> response = new List<string>();
    private string _promptChosen;
    private int _time;


    public Listing(int times)
    {
        _time = times * 1000;
    }
    public void DisplayPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompt.Count);
        string _promptStr = _prompt[number];
        _promptChosen = _promptStr;
        Console.WriteLine(_promptStr);
    }

    // Method
    public void GetInput()
    {
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
        
    }

}