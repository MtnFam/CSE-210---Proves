class GoalSaver
{
    private int _ptcounter;
    private List<Goal> _goallist;
    private string _filename;
    public GoalSaver(string _filename)
    {
        
        File.ReadLines(_filename).First();
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