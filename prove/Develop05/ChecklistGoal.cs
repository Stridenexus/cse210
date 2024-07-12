using System.ComponentModel;

public class ChecklistGoal : Goal
{
    int _timesCompleted;
    int _timesToComplete;
    bool _status;
    
    public override bool IsCompleted()
    {
        return _status;
    }
    public ChecklistGoal(string name, string description, int pointsPer, int timesToComplete, int timesCompleted = 0)
        : base (name, description, pointsPer)
        {
            _timesCompleted = timesCompleted;
            _timesToComplete = timesToComplete;
        }
    public override int CalculateScore()
    {
        return _timesCompleted * _pointsPer;
    }
    public override void Complete()
    {
        _timesCompleted++;
    }
    public override string GetInfo()
    {
        string status = _timesCompleted >= _timesToComplete ? "X" : " ";
        string nameAndDesc = _name + ": " + _description;
        string progress = " -- Currently completed: " + _timesCompleted + "/" + _timesToComplete;
        string timesText = _timesToComplete == 1 ? "time" : "times";
        return $"[{status}] {nameAndDesc}{progress} {timesText}";
    }
    public override string Serialize()
    {
        return $"ChecklistGoal:|{_name}|{_description}|{_pointsPer}|{_timesToComplete}|{_timesCompleted}";
    }
}