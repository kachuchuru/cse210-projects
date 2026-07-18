
using System.Collections.Generic;
using System.IO;
public class Journal
{
  public List<Entry> _entries= new List<Entry>(); 
  
  public void DisplayAll()
  {
    
    foreach (Entry entry in _entries)
    {
         entry.Display();
    }  
  }
  public void SaveToFile()
  {
    
    Console.Write("What is the filename?:");
    string filename=(Console.ReadLine());
    using(StreamWriter outputFile=new StreamWriter(filename))
         {
            foreach(Entry entry in _entries)
             {
        outputFile.WriteLine($"{entry._date}~{entry._bodyWeight}~{entry._promptText}~{entry._entryText}");
        
        
             }
         }
  }
    
  public void LoadFromFile()
  {
        Console.Write("What is the filename?:");
    string filename=(Console.ReadLine());
    string[] lines=System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
             {
              string[] parts= line.Split("~");
              Entry entry = new Entry();
              string _date=parts[0];
              int _bodyWeight=int.Parse(parts[1]);
              string _promptText=parts[2];
              string _entryText=parts[3];
              _entries.Add(entry);
              
             }
  }

}