using Chat.Models;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChat
{
    internal class TestsServer
    {
        [Test]
        public void ServerTest()
        {

            var mock = new MockMessageSourceServer();

            var server = new Server(mock);

            mock.AddServer(server);

            server.Work();

            using (MessageContext ctx = new MessageContext())
            {
                Assert.IsTrue(ctx.Users.Count() == 2, "Пользователи не созданы");

                var user1 = ctx.Users.FirstOrDefault(x => x.Name == "Вася");
                var user2 = ctx.Users.FirstOrDefault(x => x.Name == "Юля");

                Assert.IsNotNull(user1, "Пользователь не создан");
                Assert.IsNotNull(user2, "Пользователь не создан");

                Assert.IsTrue(user1.FromMessages.Count == 1);
                Assert.IsTrue(user2.FromMessages.Count == 1);

                Assert.IsTrue(user1.ToMessage.Count == 1);
                Assert.IsTrue(user2.ToMessage.Count == 1);

                var msg1 = ctx.Messages.FirstOrDefault(x => x.FromUser == user1 && x.ToUser == user2);
                var msg2 = ctx.Messages.FirstOrDefault(x => x.FromUser == user2 && x.ToUser == user1);

                Assert.AreEqual("От Юли", msg2.Text);
                Assert.AreEqual("От Васи", msg1.Text);

            }
        }
    }
}