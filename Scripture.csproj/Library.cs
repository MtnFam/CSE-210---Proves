
using System;
using System.Collections.Generic;
using System.IO;

class Library
{
    static void Main(string[] args)
    {
        //string[] directory = FindGitRepoRoot();
        string bob = FindGitRepoRoot();
        Console.WriteLine(bob);
    }
    static string FindGitRepoRoot()
    {
        string folder = AppDomain.CurrentDomain.BaseDirectory;

        while (folder != null)
        {
            if (Directory.Exists(Path.Combine(folder, ".git")))
            {
                return folder;
            }

            folder = Directory.GetParent(folder)?.FullName;
        }

        return null;
    }
}