
using System;
public class Reference
{
    private string _book;
    string book = "Proverbs";
    private int _chapter;
    int chapter = 3;
    private int _verse;
    int verse = 5;
    private int _endVerse;
    int endVerse = 6;

    public Reference(string book, int chapter, int verse)
    {
      _book = "Proverbs"; 
      _chapter = 3;
      _verse = 5;
      _endVerse = 5;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse= startVerse;
        _endVerse= 6;

    }
    public string GetDisplayText()
    {
        string text= $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return text;
    }
}