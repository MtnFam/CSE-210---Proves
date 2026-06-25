/*
Name: Sean Gillman
Date: 6/12/2026
*/

class Program
{
    static void Main(string[] args)
    {
        Activity active = new Activity();
        int c = 1;
        while (c != -1)
        {
            c=menu(active);
        }
    }

    static private int menu(Activity act)
        {
            Console.Clear();
            int c;
            c=-1;
            //breathing, reflection, listing
            Console.WriteLine("Choose an option or type 'quit' to exit:\n1) Breathing activity\n2) Reflection Activity\n3) 4) Lisitng Activity\n Choose loading animation");
            string input = Console.ReadLine();
            while (input != "quit" && (!int.TryParse(input, out c) || c < 0 || c > 3))
            {
                Console.WriteLine("Enter 1-3 or 'quit' to exit.");
                input = Console.ReadLine();
            };
            if (input == "quit")
            {
                c=-1;
            }
            if (c == 4)
            {
                Console.Clear();
                //swich statement with animation styles
                // make aleteranimaiton method in animation class
                act.alterAnimation();
                return c;
            }
            act.run(c-1);
            return c;
        }
}