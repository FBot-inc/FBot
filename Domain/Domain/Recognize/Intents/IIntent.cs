namespace Domain.Domain.Recognize.Intents
{
    /*
     * Интерфейс пока не имеет особой смысловой нагрузки.
     * В дальнейшем он будет убран или переписан.
     * */

    public interface IIntent
    {
        RecognizeData Recognize(string message);
    }
}