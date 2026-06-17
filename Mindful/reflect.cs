/*
Name: Nathan Hutchings
Date: 6-17-26
*/
using System;
using System.Collections.Generic;
using System.IO;

class Reflection
{
    // store member variables as private
    private int _duration;
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Animation _animation = new Animation();

    // constructor to accept time passed from Activity
    public Reflection(in duration)
    {
        _duration = duration;

        // read prompts and questions from files
        LoadFiles(reflecting_prompts.txt, _prompts);
        LoadFiles(reflecting_questions.txt, _questions);
    }

private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

public void run()
{
    Console.Clear();
    Console.WriteLine("Get ready...");

    // Run animation before starting reflection
    _animation.alterAnimation();
    Console.WriteLine();

    // Present main reflection prompt
    Console.WriteLine(GetRandomPrompt());
    Console.WriteLine("Press enter when you're ready.");
    Console.ReadLine();

    Console.WriteLine("Here's some question to ponder:");

    // 5-second countdown
    for (int i = 5; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Clear the countdown
    }
    Console.Clear();

    // Loop through the questions until the duration is up
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");

        // For running animation between questions
        _animation.alterAnimation();
        Console.WriteLine();
    }
}
}
