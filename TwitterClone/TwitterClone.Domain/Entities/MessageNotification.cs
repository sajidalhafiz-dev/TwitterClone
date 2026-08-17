namespace TwitterClone.Domain.Entities;

public class MessageNotification: Notification
{
    public MessageNotification(Guid messagedByUserId) : base("Message")
    {
        MessagedByUserId = messagedByUserId;
    }
    public Guid MessagedByUserId { get; set; }

    public override string DescribeRecord()
    {
        var describeRecord = base.DescribeRecord();
        return $"{describeRecord}, MessageByUserId = {MessagedByUserId}";
    }

    public override string GetMessage()
    {
        return $"User with ID: {MessagedByUserId} sent you a message.";
    }
}