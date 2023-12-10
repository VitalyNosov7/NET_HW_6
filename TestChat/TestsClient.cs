using Chat.Abstraction;
using Chat.Models;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestChat
{
    public class TestsClient
    {

        [Test]
        public void ClientTest()
        {
            var mock = new MockSourceClient();
        }
    }
}