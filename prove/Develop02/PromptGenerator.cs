public class PromptGenerator 
{

    public PromptGenerator()
    {
    }

    public List<string> _promptList = new List<string>() {
        "What brings you joy?", 
        "Describe a place where you felt happiest.", 
        "What was your greatest fear and how did you conquer it?", 
        "What is something that you would like to change about yourself?"
    };
    public Random _randnum = new Random();
    


    public string generatePrompt() {
        
        int num = _randnum.Next(_promptList.Count);

        return _promptList[num];
    }


}