using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                _points += _bonus;
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
{
    string checkbox;
    if (_amountCompleted >= _target)
    {
        checkbox = "[X]";
    }
    else
    {
        checkbox = "[ ]";
    }

    return checkbox + " " + _shortName + ": " + _description + 
           " (Completed " + _amountCompleted + "/" + _target + " times)";
}

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal|" + _shortName + "|" + _description + "|" + _points + "|" + _amountCompleted + "|" + _target + "|" + _bonus;
    }
}
