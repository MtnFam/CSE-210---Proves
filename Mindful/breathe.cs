/*
Name: Sean Gillman
Date: 6/9/2026
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

class Breathe
{
    private int _time = 0;
    
    public Breathe(int timeS)
    {
        _time = timeS;
    }
    public void run()
    {
        int leftover = _time%8;
        int cycle = _time/8;
        string[] breath = ["Breathe in...", "Breathe out..."];
        for (int i = cycle; i > 0; i--)
        {
            foreach (var phase in breath)
            {
                Console.WriteLine(phase);
                Thread.Sleep(1000);

                for (int count = 1; count <= 3; count++)
                {
                    Console.WriteLine($"{count}...");
                    Thread.Sleep(1000);
                }
            }
        }
        //adds 4 seconsd to end of looping but will lways be within 3s of given time
        if (leftover> 0)
        {
            foreach (var phase in breath)
            {
                Console.WriteLine(phase);
                Thread.Sleep(1000);
                Console.WriteLine("1...");
                Thread.Sleep(1000);
            }
        }
    }
}