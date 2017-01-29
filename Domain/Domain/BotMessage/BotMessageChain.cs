using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Domain.BotMessage
{
    public class BotMessageChain
    {
        private Node Head { get; set; }
        private Node Tail { get; set; }

        public BotMessageChain()
        {
        }

        public BotMessageChain(IBotMessage botMessage)
        {
            Head = Tail = new Node {BotMessage = botMessage};
        }

        /*
         * Метод возвращает коллекцию элеметов цепи доступную для чтения.
         * */
        public ReadOnlyCollection<IBotMessage> GetMessages()
        {
            var result = new List<IBotMessage>();

            if (Head == null) return result.AsReadOnly();

            var currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.BotMessage != null)
                {
                    result.Add(currentNode.BotMessage);
                }

                currentNode = currentNode.Next;
            }

            return result.AsReadOnly();
        }

        /*
         * Метод вставляет элемент в конец цепи сообщений
         * */
        public void Insert(IBotMessage botMessage)
        {
            if (Head == null)
            {
                Head = Tail = new Node {BotMessage = botMessage};
            }
            else
            {
                Tail.Next = new Node {BotMessage = botMessage};
                Tail = Tail.Next;
            }
        }

        /* 
         * Метод вставляет элемент после другого элемента,
         * указаного в аргументах.
         * Если элемент, после которого должна прозойти вставка, не найден,
         * бросается исключение: ElementNotFoundedException.
         * */ 
        public void InsertAfter(IBotMessage botMessageForInsert, IBotMessage botMessageBefore)
        {
            if (Head == null)
            {
                throw new ElementNotFoundedException();
            }

            var currentNode = Head;
            Node desiredNode = null;

            while (currentNode != null)
            {
                if (currentNode.BotMessage.Equals(botMessageBefore))
                {
                    desiredNode = currentNode;
                    break;
                }
                currentNode = currentNode.Next;
            }

            if (desiredNode == null)
            {
                throw new ElementNotFoundedException();
            }

            var nextNode = desiredNode.Next;
            
            desiredNode.Next = new Node {BotMessage = botMessageForInsert, Next = nextNode};
        }
    }


    /*
     * Исключение обозначющее, что элемент коллекции не был найден.
     * */
    public class ElementNotFoundedException : Exception
    {
    }

    /*
     * Класс представляющий узел цепи сообщений
     * */
    internal class Node
    {
        public IBotMessage BotMessage { get; set; }
        public Node Next { get; set; }
    }
}
 