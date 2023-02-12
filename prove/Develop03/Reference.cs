class Reference
{
    private string _book;
    private int _verse;
    private int _verseEnd = 0;
    private int _chapter;
    private string _verseText;


    public Reference(string book, int chapter, int singleVerse, string vText){
        _book = book;
        _chapter = chapter;
        _verse = singleVerse;
        _verseText = vText;


    }
    public Reference(string book, int chapter, int startVerse, int endVerse, string vText){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _verseEnd = endVerse;
        _verseText = vText;
    }

    public void Display(){
        if(_verseEnd == 0){
            Console.WriteLine($"{_book} {_chapter}:{_verse} {_verseText}");
        }
        else{
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_verseEnd} {_verseText}");
        }
    }
}