
using System;
using System.Diagnostics.Metrics;
using System.Numerics;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;
  
  public Scripture(Reference reference, string text)//Constructor
  {
    _reference = reference;
    _words = new List<Word>();
    string[] words = text.Split(" ");
    foreach(string word in words)
    {
      _words.Add(new Word(word));
    } 
  }
  public void HideRandomWords(int numberToHide)
{  
  int count = 0; 
  Random random = new Random();
  while (count < numberToHide)
  {

     int index =
     random.Next(_words.Count);
    
     if (!_words[index].IsHidden())
    {
      _words[index].Hide();
      count++;
    }
  }
}  
  public string GetDisplayText()
{
    string text=_reference.GetDisplayText();
    foreach (Word word in _words)
    {
      text +=word.GetDisplayText()+" ";
    } 
  return text;
}
  public bool IsCompletelyHidden() 
{
   foreach (Word word in _words)
    {
      if (!word.IsHidden())
      {
        return false;
      }
    }
   return true;
}
}