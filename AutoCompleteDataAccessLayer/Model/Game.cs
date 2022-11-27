namespace AutoCompleteDataAccessLayer.Model;
public class Game 
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Developer { get; }
    public int PublishYear { get; }

    public Game(int id, string title,  int publishYear, string developer) 
    {
        Id = id;
        Title = title;
        Developer = developer;
        PublishYear = publishYear;
    }

    public override string ToString()
    {
        return $"Game [{Id}] '{Title}', published: {PublishYear}";
    }
}