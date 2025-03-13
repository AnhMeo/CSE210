class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' recorded! +{Points} points");
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} ({Points} points per completion)";
    }

    public override string ToSaveFormat()
    {
        return $"EternalGoal,{Name},{Points}";
    }
}
