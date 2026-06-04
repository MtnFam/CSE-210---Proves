using System;
using System.Collections.Generic;
using System.IO;

class ScriptureEntry
{
    private string _reference;
    private string _passage;

    public ScriptureEntry(string reference, string passage)
    {
        _reference = reference;
        _passage = passage;
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetPassage()
    {
        return _passage;
    }
}

class Library
{
<<<<<<< HEAD:Library.cs
    private List<ScriptureEntry> list;
=======
    
    static string FindGitRepoRoot()
    {
        string folder = AppDomain.CurrentDomain.BaseDirectory;
>>>>>>> 920863c74cf0958d92bcb33c7fc9d1957db4bab8:Scripturemem/Library.cs

    public Library()
    {
        list = new List<ScriptureEntry>();

        string _path = @"C:\Users\barbe\Documents\BYU-I\Spring 2026\CSE 210 - Programing with Classes\CSE210-Projects\CSE-210---Proves\library.txt";

        string[] scriptureLines = File.ReadAllLines(_path);

        foreach (string line in scriptureLines)
        {
            
            string[] col = line.Split('|');

            if (col.Length == 2)
            {
                ScriptureEntry entry = new ScriptureEntry(col[0], col[1]);
                list.Add(entry);
            }
        }
    }

    public List<ScriptureEntry> GetAll()
    {
        return list;
    }
}
