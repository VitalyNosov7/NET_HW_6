## Домашнее задание к Уроку 6. Тестирование приложений: test driven development:

Продумайте, как можно протестировать код клиента по аналогии с кодом сервера.

---
## Решение:

Для решения текущей задачи были проделаны следующие действия:

1. Был создан класс MockSourceClient с кодом:
```
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
```
2. Был создан класс TestsClient с кодом:
```
        [Test]
        public void ClientTest()
        {
            var mock = new MockSourceClient();
        }
```

Далее столкнулся с трудностями в понимании того, как работает тестируемая программа, что привело к затруднению написания теста работы класса Client.
Домашнее задание считаю не выполненным.