namespace Domain.Domain
{
    public interface IIntent
    {
        bool Recognize(string message);
    }
}