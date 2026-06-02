using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture script = new Scripture();
        int c = 1;
        while (c != 0)
        {
            c=menu();
        }
    }
    static private int menu(Scripture scr)
    {
        Console.WriteLine("Choose an option or type 'quit' to exit:\n1) Learn random scripture\n2)Learn chosen scripture (must be in library)\n 3) Save new Scripture");
        string input = Console.ReadLine();
        int c;
        while(!int.TryParse(input, out c)||input!="quit");
        {
            Console.WriteLine("Invalid input. Please enter a whole number or type 'quit' to exit.");
            input = Console.ReadLine();   
        };
        if (input == "quit")
        {
            c=0;
        };
        switch (c)
        {
            case 1://Learn random
            Random num = new Random();
            num.Next(0,scr.library.Count());
            // find new scripture in lib from rand index
            // open scripture

            case 2: //learn chosen
                Console.WriteLine("Enter a reference in the form John 1:5 or Moroini 7:47-48\nEnsure there are capitals and spaces where needed");
                string sref = Console.ReadLine();
                if (sref.Contains('-'))
                {
                    // search as a list of verses
                }
                else
                {
                    // search lib as normal reference
                }
                // open scripture 

            case 3://Save
        }
        return c;
  
    }
}