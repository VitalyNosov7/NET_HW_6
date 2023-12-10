using Chat.Abstraction;
using Chat.Models;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestChat
{
    public class MockSourceClient
    {

        IMessageSource message;
        private Queue<Client> clients = new Queue<Client>();

        public MockSourceClient()
        {
            clients.Enqueue(new Client(message, "127.0.0.1", 12345, "Василий"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12346, "Мария"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12347, "Юрий"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12348, "Эмиль"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12349, "Виктория"));
        }
    }
}