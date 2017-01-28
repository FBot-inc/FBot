namespace Domain.Domain.Recognize
{
    /*
     * Класс содержащий информацию полученную при распознование строки.
     * В дальнейшем будет содеражть информацию о том с какой вероятностью строки совпадают.
     * А так же список информационных триплетов полученных из строки.
     * */

    public class RecognizeData
    {
        public bool ResultOfComparisin { get; set; }
    }
}