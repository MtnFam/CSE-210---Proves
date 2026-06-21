/*Renae Rogers - 6/9/26 - 6/21/26
    -Used project requirement and w3schools for reference
*/
using System;
using System.Collections.Generic;
using System.Threading;

class Animation
{
    // Sets a default animation style -Renae 
    private int _animationType = 0;

    public Animation()
    {
        // Constructor
    }

    // Handles animation style selection based on choice -Renae
    public void SetAnimationType(int choice)
{
    // Checks if choice is one of the options or not
    // If the choice isn't valid, it defaults to 0 
    if (choice >= 0 && choice <= 2)
    {
        _animationType = choice;
    }
    else
    {
        _animationType = 0; 
    }
}

    public void Play(int seconds)
    {
        Console.CursorVisible = false;

        // Number of frames per second
        int totalFrames = (seconds * 1000) / 150;

        List<string> frames = GetAnimationFrames();
        int frameIndex = 0;

        for (int i = 0; i < totalFrames; i++)
        {
            string currentFrame = frames[frameIndex];
            
            Console.Write(currentFrame);
            Thread.Sleep(150);

            // Some of the animation lengths are different, 
            // so this checks to see length to make sure all of the characters are removed
            for (int j = 0; j < currentFrame.Length; j++)
            {
                Console.Write("\b \b");
            }

            frameIndex = (frameIndex + 1) % frames.Count;
        }

        Console.CursorVisible = true;
    }
    // Here's the different animations to choose from -Renae 
    private List<string> GetAnimationFrames()
    {
        switch (_animationType)
        {
            case 1:
                return new List<string> { ".", "..", "...", "....", "...", ".." };
            
            case 2:
                return new List<string> { "[    ]", "[=   ]", "[==  ]", "[=== ]", "[====]", "[ ===]", "[  ==]", "[   =]" };
            
            case 0:
            default:
                return new List<string> { "|", "/", "-", "\\" };
        }
    }
}