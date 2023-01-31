class Entry {

    public Entry () {
    }

    //public string _prompt;
    public DateTime _date = DateTime.Now;
   
    //public string _response;

    public string getPrompt () {
        PromptGenerator pGen = new PromptGenerator();
        string aPrompt = pGen.generatePrompt();
        return aPrompt;
    }

    public string currentDate () {
        string dateText = _date.ToShortDateString();
        return dateText;
    }

    
    public void displayEntry (string dateCurrent, string prompt, string response ) {

        Console.WriteLine($"Date: {dateCurrent} - Prompt: {prompt}");
        Console.WriteLine($"{response}");
        Console.WriteLine();
    }

}


