## �������� ������� � ����� 6. ������������ ����������: test driven development:

����������, ��� ����� �������������� ��� ������� �� �������� � ����� �������.

---
## �������:

��� ������� ������� ������ ���� ��������� ��������� ��������:

1. ��� ������ ����� MockSourceClient � �����:
```
        IMessageSource message;
        private Queue<Client> clients = new Queue<Client>();

        public MockSourceClient()
        {
            clients.Enqueue(new Client(message, "127.0.0.1", 12345, "�������"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12346, "�����"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12347, "����"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12348, "�����"));
            clients.Enqueue(new Client(message, "127.0.0.1", 12349, "��������"));
        }
```
2. ��� ������ ����� TestsClient � �����:
```
        [Test]
        public void ClientTest()
        {
            var mock = new MockSourceClient();
        }
```

����� ���������� � ����������� � ��������� ����, ��� �������� ����������� ���������, ��� ������� � ����������� ��������� ����� ������ ������ Client.
�������� ������� ������ �� �����������.