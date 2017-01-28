using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Factory;

namespace Domain.Domain
{
    public class Bot
    {
        private readonly Dictionary<string, UserContext> _userContexts = new Dictionary<string, UserContext>();

        public List<string> HelloMessages = new List<string>
        {
            "Привет меня зовут FBot"
        };

        private readonly MessageGraph _currentMessageGraph = MessageGraphFacroty.CreateHelloMessageGraph();

        /*Функция, которую должен вызывать пользователь перед общением с ботом.
         * Функция возвращет данные для подключение к боту:
         * Ид пользователя - который необходим отправлять с каждым сообщением.
         */
        public ConnectData Connect()
        {
            var userId = Guid.NewGuid().ToString();
            
            var userContext = new UserContext
            {
                UserId = userId
            };

            _userContexts.Add(userId, userContext);

            var connectData = new ConnectData
            {
                UserId = userId
            };
            
            connectData.Messages.AddRange(HelloMessages);

            return connectData;
        }

        /*Функция для общения с пользователем
         * */
        public Response Communicate(string message, string userId)
        {
            if (!_userContexts.ContainsKey(userId))
            {
                var errorResponse = new Response {IsError = true};

                errorResponse.Messages.AddRange(new List<string>
                {
                    "Пользователь с таким ид не найден.",
                    "Проверьти правильность ввода ид.",
                    "Или подключитесь к боту"
                });

                return errorResponse;
            }

            var response = new Response();

            if (_currentMessageGraph.Next(message, userId))
            {
                var messages = _currentMessageGraph.Read(userId);

                response.Messages.AddRange(messages.Select(p => p?.Text));
            }

            return response;
        }
    }
}
