/*Renae Rogers - 6/9/26 
    -Used porject requirement and w3schools for reference
*/
using System;
using System.Threading;

class Animation
{    
    static void SpinCycle()
    {
        // 1. Hide the cursor for a cleaner look
        Console.CursorVisible = false;

        // 2. Define the frames of the spinner
        string[] spinnerFrames = { "--", "\\", "|", "/" };
        
        for (int i = 0; i <= 20; i++)
        {
            Console.Write(i);
            foreach (string frame in spinnerFrames)
            {
                Console.Write(frame);
                Thread.Sleep(150);
                Console.Write("\b \b");
            }
        }

        Console.CursorVisible = true;
        Console.Clear();
        Console.WriteLine("Task Complete!");
    }
}
