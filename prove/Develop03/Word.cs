class Word
{
    private string _word;

    public Word()
    {
    }

    public string HiddenOrNot(string word){

        foreach(char letter in word){
            _word += "_";
        }
        return _word;

    }


}