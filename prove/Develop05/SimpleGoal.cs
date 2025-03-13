class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, bool isComplete = false) : base(name, points)
    {
        IsComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! +{Points} points");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete ? "X" : " ")}] {Name} ({Points} points)";
    }

    public override string ToSaveFormat()
    {
        return $"SimpleGoal,{Name},{Points},{IsComplete}";
    }
}
