
using System;
using System.Numerics;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture (Reference reference, string text)
  {
    _reference = reference;
    _words = new List<Word>(); 
    
  }
  public void HideRandomWords()
{
    
    return;
}  
  public string GetDisplayText()
{
    string text="";
  return text;
}
  public bool IsCompletelyHidden()

{
   
   return false;
}
}