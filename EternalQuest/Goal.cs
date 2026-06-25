using System.ComponentModel.DataAnnotations.Schema;

class Goal
{
    private int _points;
    private string _type;
    private string _name;
    private bool _iscomplete;
     public Goal(string name, string type, int points)
    {
        _iscomplete=false;
        _name =name;
        _type=type;
        _points=points;
    }

    void complete()
    {
        _iscomplete=true;
    }
}