namespace Domain.Domain
{
    public class LinkFromIntentToMessage
    {
        public Intent From { get; set; }
        public Message To { get; set; }
    }

    public class LinkFromMessageToIntent
    {
        public Message From { get; set; }
        public Intent To { get; set; }
    }

    public class LinkFromMessageToMessage
    {
        public Message From { get; set; }
        public Message To { get; set; }
    }
}