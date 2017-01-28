using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Domain;

namespace CUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bot = new Bot();

            var connectionData = bot.Connect();

            foreach (var message in connectionData.Messages)
            {
                Console.WriteLine("Bot:  " + message);
            }

            while (true)
            {
                Console.Write("User: ");

                var userMessage = Console.ReadLine();

                var response = bot.Communicate(userMessage, connectionData.UserId);

                foreach (var message in response.Messages)
                {
                    Console.WriteLine("Bot: " + message);
                }
            }

            Console.ReadKey();
        }
    }
}
