namespace TwitterClone.Domain.Entities;

public class Like
{
    private Guid _userId;
    private Guid _tweetId;
    private DateTime _likedAt;
    
    public Guid UserId { get => _userId; }
    public Guid TweetId { get => _tweetId; }
    public DateTime LikedAt { get => _likedAt; }
    
}