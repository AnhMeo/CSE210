class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int BonusPoints => _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override void RecordEvent()
    {
        if (IsComplete)
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
            return;
        }

        _currentCount++;
        Console.WriteLine($"Progress on '{Name}': {_currentCount}/{_targetCount} (+{Points} points)");

        if (_currentCount >= _targetCount)
        {
            IsComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! Bonus: +{_bonusPoints} points!");
        }
    }

    public override string GetStatus()
    {
        return $"[{_currentCount}/{_targetCount}] {Name} ({Points} points per step, {_bonusPoints} bonus for completion)";
    }

    public override string ToSaveFormat()
    {
        return $"ChecklistGoal,{Name},{Points},{_targetCount},{_currentCount},{_bonusPoints}";
    }
}