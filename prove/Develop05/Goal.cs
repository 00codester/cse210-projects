class Goal{

    protected string _name;
    protected string _description;
    protected int _points;
    // protected int _totalpoints;
    protected bool _isCompleted = false;
    protected string _checkBox = "[ ]";

    public Goal(){
    }

//setter section
    public void SetName (string name){
        _name = name;
    }

    public void SetDesc (string desc){
        _description = desc;
    }

    public void SetPoints (int points){
        _points = points;
    }

    public void SetisCompleted (bool complete){
        _isCompleted = complete;
    }

    public void SuperSetterGoal(string name, string desc, int points){
        SetName(name);
        SetDesc(desc);
        SetPoints(points);
    }

    public virtual string GetStringRepresentation(){
        return "";
    }

//getter section
    public string GetName(){
        return _name;
    }

    public string GetDesc(){
        return _description;
    }

    public int AddPoints(){
        return _points;
    }



    public void FinishedGoal(){
        _checkBox = "[X]";
    }



    protected virtual void GoalSpecific(){
    }

    public void GetInfo(){
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points assoicated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        GoalSpecific();
    
    }

    public virtual int Congratulations(){
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        GoalComplete();
        return AddPoints();
    }

    protected virtual void GoalComplete(){

    }

    protected virtual void ExtraDisplay(){
        Console.WriteLine();
    }

    public void DisplayGoal(int number){
        Console.Write($"{number}. {_checkBox} {_name} ({_description})");
        ExtraDisplay();
    }

    public void EditGoalDisplay(int number){
        Console.WriteLine($"{number}. {_name}");
    }

}