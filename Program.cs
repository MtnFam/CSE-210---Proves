using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
        Scripture script = new Scripture();
        Console.WriteLine("Choose an option or type 'quit' to exit:\n1) Learn random scripture\n2)Learn chosen scripture (must be in library)\n 3) Save new Scripture");
        string input = Console.ReadLine();
        int c;
        while (input != "quit" &&
       (!int.TryParse(input, out c) || c < 0 || c > 3))
        {
            Console.WriteLine("Enter 0-3 or 'quit' to exit.");
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
            int scrindex = num.Next(1,File.ReadAllLines("file.txt").Length);
            // find new scripture in lib from rand index
            // open scripture

            case 2: //learn chosen
                Console.WriteLine("Enter a reference in the form John 1:5 or Moroini 7:47-48\nEnsure there are capitals and spaces where needed");
                string sref = Console.ReadLine();
                
                // open scripture 

            case 3://Save
            Console.WriteLine("Enter a reference in the form John 1:5 or Moroini 7:47-48\nEnsure there are capitals and spaces where needed");
            string nref = Console.ReadLine();
            Console.WriteLine("Enter the complete passage text");
            string npas = Console.ReadLine();
            File.AppendAllText(libname, $"{nref}||{npas}" + Environment.NewLine);
        }
        return c;
  
    }
    static private Scripture getscript(string library,int index)
    {
        string line = File.ReadLines(library).Skip(index-1).First();
        
        string[] parts = input.Split('|');
        string reference = parts[0];
        string passage = parts[1];
        Scripture script = new Scripture(reference,passage);
    }
}