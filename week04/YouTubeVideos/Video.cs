using System.Collections.Generic;
using System.IO;
public class Video
{
  public string _title= "";

  public string _author="";

  public int _length; 
  
  public List<Comment> _comments; 

  public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
  
  public void AddComment(Comment comment)
    {
    _comments.Add(comment);
    }
  
  public int GetItemCount()
    {
        return _comments.Count;
    }

  public void Display()
  {
    Console.WriteLine($"Title:{_title}");
    Console.WriteLine($"Author:{_author}");
    Console.WriteLine($"Length of the video:{_length}seconds");
    Console.WriteLine($"Number of Comments:{_comments.Count}");
     foreach (Comment comment in _comments)
    {
         comment.Display();
    }  
  }
}