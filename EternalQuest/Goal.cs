using System.ComponentModel.DataAnnotations.Schema;

class Goal
{
    protected int _points;
    protected string _name;
    protected bool _iscomplete;
     public Goal(string name, int points)
    {
        _iscomplete=false;
        _name =name;
        _points=points;
    }

    public void Complete()
    {
        _iscomplete=true;
    }
}
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
        
    }
}
class EternalGoal : Goal
{
    public void Complete()
    {
        return;
    }
}
class ChecklistGoal : Goal
{
    
}