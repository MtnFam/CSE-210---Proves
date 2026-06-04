using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string libname = "library.txt";
        int c = 1;
        while (c != 0)
        {
            
            c=menu(libname);
        }
    }
    static private int menu(string libname)
    {
        Console.Clear();
        int c;
        c=-1;
        Console.WriteLine("Choose an option or type 'quit' to exit:\n1) Learn random scripture\n2) Learn chosen scripture (must be in library)\n3) Save new Scripture");
        string input = Console.ReadLine();
        while (input != "quit" && (!int.TryParse(input, out c) || c < 0 || c > 3))
        {
            Console.WriteLine("Enter 1-3 or 'quit' to exit.");
            input = Console.ReadLine();
        };
        if (input == "quit")
        {
            c=0;
        }
        switch (c)
        {
            case 1://Learn random
                Random num = new Random();
                var lines = File.ReadAllLines(libname);
                int scrindex = num.Next(1, lines.Length + 1);
                Scripture scr = GetScript(libname, scrindex);
                showscripture(scr);
                break;

            case 2: //learn chosen
                Console.WriteLine("Enter a reference in the form John 1:5 or Moroini 7:47-48\nEnsure there are capitals and spaces where needed");
                string sref = Console.ReadLine();
                scr = GetScriptFRef(libname,sref); 
                showscripture(scr);
                Console.WriteLine("Not implemented yet");
                break;

            case 3://Save
                Console.WriteLine("Enter a reference in the form John 1:5 or Moroini 7:47-48\nEnsure there are capitals and spaces where needed");
                string nref = Console.ReadLine();
                Console.WriteLine("Enter the complete passage text");
                string npas = Console.ReadLine();
                File.AppendAllText(libname, $"{nref}|{npas}" + Environment.NewLine);
                break;
        }
            return c;
    }
    private static Scripture GetScript(string library, int index)
    {
        string line = File.ReadLines(library).Skip(index - 1).First();
        List<string> parts = line.Split('|', 2).ToList();
        return new Scripture(parts[0], parts[1]);
    }
    private static Scripture GetScriptFRef(string library, string sref)
    {
        int lineNumber = 0;

        foreach (string line in File.ReadLines(library))
        {
            lineNumber++;
            string[] parts = line.Split('|', 2);
            if (parts.Length > 0 &&
                parts[0].Equals(sref, StringComparison.OrdinalIgnoreCase))
            {
                return GetScript(library,lineNumber);
            }
        }
       throw new ArgumentException($"Scripture reference '{sref}' was not found.");
    }
    private static void showscripture(Scripture script)
    {
        string input = "";

    while (input != "quit")
    {
        Console.Clear();
        Console.WriteLine(script.ToString()); 
        Console.WriteLine("\nPress enter to continue or 'quit' to finish");
        input = Console.ReadLine();
        if (input != "quit")
        {
            script.HideWords(3);
        }
    }
    return;
    }
}