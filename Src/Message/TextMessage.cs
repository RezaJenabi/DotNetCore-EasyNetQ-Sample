using System.Collections.Generic;
using EasyNetQ;

namespace Messages
{
	[Queue(queueName: "ClientQueue", ExchangeName = "ClientExchange")]
    public class TextMessage
    {
        public string Text { get; set; }
    }
}
