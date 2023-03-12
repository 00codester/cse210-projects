class Eternal : Goal{

    public Eternal(){

    }
    public override string GetStringRepresentation()
    {
        string output = $"{GetType()}:{_name},{_description},{_points}";
        return output;
    }
}