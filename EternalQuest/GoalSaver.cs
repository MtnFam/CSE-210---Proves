class GoalSaver
{
    private int _ptcounter;
    private List<Goal> _goallist;
    private string _filename;
    public GoalSaver(string _filename)
    {   
        _ptcounter = int.Parse(File.ReadLines(_filename).First());
        _goallist = readGoals(_filename);
    }
    public List<Goals> readGoals(string filename)
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

            List<string> parts = line.Split('|', 2).ToList();
        }
}
/*Random num = new Random();
        var lines = File.ReadAllLines(libname);
        int scrindex = num.Next(1, lines.Length + 1);
        Scripture scr = GetScript(libname, scrindex);
        showscripture(scr);
    string line = File.ReadLines(library).Skip(index - 1).First();
        List<string> parts = line.Split('|', 2).ToList();
        return new Scripture(parts[0], parts[1]);
*/