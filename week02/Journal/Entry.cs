

public class Entry
{
  public string _date="";
  public int _bodyWeight;
  public string _promptText="";
  public string _entryText="";
  public void Display()
    {
      Console.WriteLine($"Date:{_date}, Body Weight:{_bodyWeight}");
      Console.WriteLine($"Prompt:{_promptText}, {_entryText}");  
    }



}