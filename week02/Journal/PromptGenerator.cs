

public class PromptGenerator
{
    public List<string>_prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What are you grateful for?");
        _prompts.Add("Who was someone that helped you today?");
        _prompts.Add("What was the most dissapointing situation you encoutered today?");
        _prompts.Add("What are your regrets for the last week");
        _prompts.Add("What did you learn today in your BYU modules?");
        _prompts.Add("Who did you go with for lunch today?");
        _prompts.Add("Which verse from the Book of Mormon had inspired you during your daily scripture study?");
    }
    public string GetRandomPrompt()
    {
      Random random = new Random();
      int index =random.Next(_prompts.Count);
        return _prompts[index];
    }
}