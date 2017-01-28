namespace Domain.Domain.Recognize.Templates
{
    public interface ITemplate
    {
        /*
         * Метод который должен сравнивать входную строку со строкой внутри класса 
         * и выдвать информацию полученую при сравнении.
         * */
        RecognizeData Recognize(string message);
    }
}
