class Scripture
{
    private string[] _verse;
    private List<int> _usedRandNums = new List<int>();
    private int _rand;
    private string _verseHidden;
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    public Scripture(string book, int chapter, int singleVerse, string verseText){
        _verse = verseText.Split(" ");
        _book = book;
        _chapter = chapter;
        _startVerse = singleVerse;
        _verseHidden = verseText;
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse, string verseText){
        _verse = verseText.Split(" ");
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _verseHidden = verseText;
    }

    public void hiddenWordSelector(){
        Random rnd = new Random();
        int listLength = _verse.Length;        

        for (int i = 0; i < 2; i++){
            Word myWord = new Word();

            if (listLength != _usedRandNums.Count) {
                do{
                    _rand = rnd.Next(listLength );
                } while (_usedRandNums.Contains(_rand));
                _usedRandNums.Add(_rand);
            }
            _verse[_rand] = myWord.HiddenOrNot(_verse[_rand]);
        }

        hiddenVerseCombiner();

    }

    public bool gameOver(){
        if (_verse.Length == _usedRandNums.Count){
            return true;
        }
        else {
            return false;
        }
    }

    private void hiddenVerseCombiner(){
        _verseHidden = "";
        foreach (string word in _verse){
            _verseHidden = _verseHidden + word + " ";
        }
    }


    public void Display(){
        Reference theRef = new Reference(_book, _chapter, _startVerse, _endVerse, _verseHidden);
        theRef.Display();
    }
}