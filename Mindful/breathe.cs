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
        leftover = leftover*1000;
        tot = tot*1000;
        for (int i = cycle; i > 0; i--)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("1...");
            Thread.Sleep(1000);
            Console.WriteLine("2...");
            Thread.Sleep(1000);
            Console.WriteLine("3...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out");
            Thread.Sleep(1000);
            Console.WriteLine("1...");
            Thread.Sleep(1000);
            Console.WriteLine("2...");
            Thread.Sleep(1000);
            Console.WriteLine("3...");
            Thread.Sleep(1000);
        }
        for (int i = leftover; i > 0; i--)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("1...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out");
            Thread.Sleep(1000);
            Console.WriteLine("1...");
            Thread.Sleep(1000);
        }
    }
}