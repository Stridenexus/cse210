class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    public Reference(string b, int ch, int vF, int vL)
    {
        _book = b;
        _chapter = ch;
        _firstVerse = vF;
        _lastVerse = vL;
    }
    public void GetReference()
    {
        Console.WriteLine($"{_book}, {_chapter}:{_firstVerse}-{_lastVerse}");
    }
}