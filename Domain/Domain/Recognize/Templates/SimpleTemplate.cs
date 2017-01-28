namespace Domain.Domain.Recognize.Templates
{
    /*
     * Класс представляет минимальнюу еденицу распознования входных сообщений.
     * Данный вид шаблонов представляет возможности, только для полного сравнения предложений.
     * Так же класс не извлекает информацию из предложений.
     * */

    public class SimpleTemplate : ITemplate
    {
        //строка по которой происходит сравнения
        private readonly string _templateString;

        public SimpleTemplate(string templateString)
        {
            _templateString = templateString;
        }

        public RecognizeData Recognize(string message)
        {
            var result = new RecognizeData();

            if (message == null)
            {
                result.ResultOfComparisin = _templateString == null;
            }
            else
            {
                result.ResultOfComparisin = message.Equals(_templateString);
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            var template = obj as SimpleTemplate; 

            return template != null && template._templateString.Equals(_templateString);
        }

        protected bool Equals(SimpleTemplate other)
        {
            return string.Equals(_templateString, other._templateString);
        }

        public override int GetHashCode()
        {
            return _templateString?.GetHashCode() ?? 0;
        }
    }
}