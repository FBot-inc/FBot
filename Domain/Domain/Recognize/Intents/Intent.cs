using System.Collections.Generic;
using System.Linq;
using Domain.Domain.Recognize.Templates;

namespace Domain.Domain.Recognize.Intents
{
    /*
     * Класс представляющий собой языкое понятие.
     * Внутри содержит список синонимичных интентов, 
     * по которым происходит сравнение входной строки.
     * */
    public class Intent : IIntent
    {
        private readonly List<ITemplate> _templates = new List<ITemplate>();

        /*
         * Метод возвращающий список шаблонов, доступных в интенте.
         * Список доступен только для чтения.
         * 
         * */
        public IReadOnlyList<ITemplate> GetTemplates()
        {
            return _templates.AsReadOnly(); 
        }

        /*
         * Метод для добавления нового шаблона в интент.
         * Если шаблон уже содержится в интенте, он не будет добавлен.
         * */
        public void AddTemplate(SimpleTemplate simpleTemplate)
        {
            if (!_templates.Contains(simpleTemplate))
            {
                _templates.Add(simpleTemplate);
            }
        }

        /*
         * Метод для удаления шаблона из интента.
         * */
        public void DeleteTemplate(SimpleTemplate simpleTemplate)
        {
            _templates.Remove(simpleTemplate);
        }

        /*
         * Функция производящая распознование.
         * На данный момент возвращает только булевое значение,
         * которое означает найдено(true) значение входной строки в одном из интентов или нет(false).
         * В дальнейшем будет возврщать вариант с наибольшим коэффциентом вероятности совпадения.
         * */
        public bool Recognize(string message)
        {
            return _templates.Any(p => p.Recognize(message).ResultOfComparisin);
        }
    }
}