using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.BotMessage
{
    /*
     * Первоначальный вариант архитектуры сообщений
     * Не уверен, что правильный.
     * В дальнейшем свойство будет заменено на метод,
     * либо интерфейс на родительский класс.
     * */
    public interface IBotMessage
    {
        string Text { get; }
    }
}
