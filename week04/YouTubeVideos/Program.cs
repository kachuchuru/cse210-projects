using System;

class Program
{
    static void Main(string[] args)
    {
       
       List<Video> videos = new List<Video>();
       
       Video video1 = new Video("How to raise chickens", "Nurdin Kiluvia", 450); 
        Comment comment1=new Comment("Adam", "highly edified");       
        Comment comment2=new Comment("Lulu", "powerful ideas");
        Comment comment3=new Comment("Brian", "I will try these ideas");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

      Video video2 = new Video("How to cook banana cake", "Shamimu Mohamed", 320); 
        Comment comment4=new Comment("Abigail", "The recipe is wonderful");       
        Comment comment5=new Comment("Mary", "Waoh I did not know this before");
        Comment comment6=new Comment("Michele", "I have really enjoyed learning these ideas"); 
        Comment comment7=new Comment("Lemba"," I will share this recipe with mummy");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
      
     Video video3 = new Video("How to start a business in construction", "Eng Kachu", 520); 
        Comment comment8=new Comment("Dula", "I can now get started");       
        Comment comment9=new Comment("Samuya", "I need a fried to form a joint venture");
        Comment comment10=new Comment("Lissu", "Thanks so much. Really appreciated"); 
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);
     
     videos.Add(video1);
     Console.WriteLine();
     videos.Add(video2);
     Console.WriteLine();
     videos.Add(video3);
    
     foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
     
    }
}

