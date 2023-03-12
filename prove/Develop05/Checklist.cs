class Checklist : Goal {

    private int _grandTotal;
    private int _gTotalSoFar;
    private int _bonusPoints;


    public Checklist(){

    }

//setter section
    public void SetGTotal(int gtotal){
        _grandTotal = gtotal;
    }

    public void SetGTotalSoFar(int gtsofar){
        _gTotalSoFar = gtsofar;
    }

    public void SetBP(int bp){
        _bonusPoints = bp;
    }

    public void SuperSetterChecklist(int gtotal, int gtsofar, int bp){
        SetGTotal(gtotal);
        SetGTotalSoFar(gtsofar);
        SetBP(bp);
    }

//getter section
    public int GetGTotal(){
        return _grandTotal;
    }

    public int GetGTotalSoFar(){
        return _gTotalSoFar;
    }

    public int GetBonusP (){
        return _bonusPoints;
    }

    protected override void GoalSpecific(){
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _grandTotal = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    public override int Congratulations()
    {
        //return base.Congratulations();
        AddSoFar();
        if (_gTotalSoFar == _grandTotal){
            
            FinishedGoal(); // checkbox X out
            // return AddPoints() + AddBonusPoints();
            int smallP = AddPoints();
            int bigP = AddBonusPoints();
            int sumOfP = smallP + bigP;
            Console.WriteLine($"Congratulations! You have earned {sumOfP} points!");
            return sumOfP;

        }
        else {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return AddPoints();
        }

    }

    public override string GetStringRepresentation()
    {
        string output = $"{GetType()}:{_name},{_description},{_points},{_bonusPoints},{_grandTotal},{_gTotalSoFar}";
        return output;
    }

    public void AddSoFar(){
        _gTotalSoFar += 1;
    } 

    public int AddBonusPoints(){
        return _bonusPoints;
    }

    public int GetGrandTotal(){
        return _grandTotal;
    }

    protected override void ExtraDisplay()
    {
        Console.WriteLine($" -- currently completed: {_gTotalSoFar}/{_grandTotal}");
        
    }

}