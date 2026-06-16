/*
Name: Sean Gillman
Date: 6/11/2026
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;

class Activity
{
    //breathing, reflection, listing
    private List<string> _intro = ["This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."];
    private List<string> _name = ["Breathing Activity","Refleciton Activity","Lisitng ACtiviity"];

    private Animation _loading = new Animation();

    public Activity()
    {
        
    }
    public void run(int actnum)
    {
        int time = intro(actnum);
        switch (actnum)
        {
            case 0://breathe
            Breathe br = new Breathe(time);
            br.run();
            break;
            case 1://listing
            Reflection re = new Reflection(time);
            re.run();
            break;
            case 2://listing
            Listing li = new Listing(time);
            li.run();
            break;
        }
        outro(actnum);
    }
    private int intro(int actnum)
    {
        Console.WriteLine($"Welcome to the {_name[actnum]}.\n\n{_intro[actnum]}\nFor how long, in seconds, would you like for your session?");
        int time;
        while (!int.TryParse(Console.ReadLine(), out time))
        {
            Console.WriteLine("Please enter a valid whole number:");
        }
        return time;
        }
    private void outro(int actnum)
    {
        Console.WriteLine($"\n\nYou have just completed the {_name[actnum]}, great job!");
        //add loading animation with buffer
    }
    
    public void alterAnimation()
    {
        _loading.alterAnimation();
    }
}
