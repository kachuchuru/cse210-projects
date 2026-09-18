
using System;
using System.ComponentModel;
public class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
       _text = text;
       _IsHidden= false; 
    }

    public void Hide()
    {
      _IsHidden=true;  
    }

    public void Show()
    {
     _IsHidden=false;   
    }

    public bool IsHidden()
    {

      return _IsHidden; 
    }

    public string GetDisplayText()
    {
       if (_IsHidden)
        {
         return "____";  // _text.Length="_"
        }
        else
        {
            return _text;
        }
    
       
    }
}