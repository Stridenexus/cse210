using System.Globalization;

class Scripture
{
    private List<Word> _verse = new List<Word>();
    private List<int> _amount = new List<int>();
    //Reference to come later

    public Scripture()
    {
        string myVerse = "I am Alpha and Omega, the Beginning and the End, I shall give unto Him that is athirst of the Fountain of the Water of Life, Freely. He that overcometh shall inherit all things; and I will be his God, and he shall be my son.";
        string[] splitVerse = myVerse.Split(" ");
        foreach(string word in splitVerse)
        {
            _verse.Add(new Word(word));
            _amount.Add(_verse.Count-1);
        }
    }
    public string GetScriptureDisplay()
    {
        string result = "";
        foreach(Word word in _verse)
        {
            result = result+word.GetWord()+" ";
        }
        return result;
    }
    public void GetNumber()
    {
        int number = _amount.Count;
        if (number > 0)
        {
            Random rand = new Random();
            int hideThis = rand.Next(number);
            _verse[_amount[hideThis]].Hide();
        }
    }
}