class Word
{
    private string _word;
    private bool _hidden;

    public Word(string theWord)
    {
        _word = theWord;
        _hidden = false;
    }
    public string GetWord()
    {
        return _hidden?"____":_word;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void Hide()
    {
        _hidden = true;
    }
}