using System;
using Domain.Domain.InformationContext;

namespace Domain.Domain.BotMessage
{
    /*
     * Класс представляет собой сущность,
     * которую можно использовать для сборки сложных сообщений
     * по шаблонам и триплетным источникам: контекст пользователя, сторонние сервисы, скрипты и тд.
     * */
    public class CompoundBotMessage : IBotMessage
    {
        //Шаблон по которому будет составляться сообщение.
        private string _textTemplate;
        //Источник из которого будет браться информация для сообщения.
        private ITripleteSource _tripleteSource;

        public string Text
        {
            get
            {
                /*
                 * Вызывается метод проверки доступности сообщения,
                 * если оно не доступно бросается исключени.
                 * */
                if (!CheckAvalible())
                {
                    throw new AssambleMessageNotAvalibleException();
                }

                return Assamble();
            }
        }

        public CompoundBotMessage(string textTemplate, ITripleteSource tripleteSource)
        {
            _tripleteSource = tripleteSource;
            _textTemplate = textTemplate;
        }

        /*
         * Метод проверяет содержит ли источник информацию требуемую для составления сообщения.
         * Пока метод не доступен, так как этот функционал в данный момент не используется.
         * */
        public bool CheckAvalible()
        {
            throw new NotImplementedException();
        }

        /*
         * Метод собирает сообщение на основе шаблона и информации полученой из источника.
         * Пока метод не доступен, так как этот функционал в данный момент не используется.
         * */
        public string Assamble()
        {
            throw new NotImplementedException();
        }

    }

    /*
     * Исключение, показывающее, что в данный момент в источнике данных не достаточно информации
     * для сборки сообщения. Следовательно, сборка сообщения недоступна.
     * */
    public class AssambleMessageNotAvalibleException : Exception
    {
    }
}