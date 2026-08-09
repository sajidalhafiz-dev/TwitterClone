namespace TwitterClone.Domain.Entities;

public class Tweet
{
    private Guid _id;
    private Guid _authorId;
    private string _content;
    
    public Guid Id
    {
        get => _id;
    }
    public Guid AuthorId
    {
        get => _authorId;
    }

    public string Content
    {
        get => _content;
        set => _content = value;
    }
}