class Simple : Goal {

public Simple(){

}
    protected override void GoalComplete()
    {
        FinishedGoal();
        _isCompleted = true;
    }

    public override string GetStringRepresentation()
    {
        string output = $"{GetType()}:{_name},{_description},{_points},{_isCompleted}";
        return output;
    }

}