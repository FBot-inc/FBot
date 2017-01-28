namespace Domain.Domain.Recognize.Intents
{
    /*
     * Интерфейс пока не имеет особой смысловой нагрузки.
     * В дальнейшем он будет убран или переписан.
     * */

    public interface IIntent
    {
        bool Recognize(string message);
    }
}