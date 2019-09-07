using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyNetQ.AutoSubscribe;
using Messages;

namespace Consumer.Handlers
{
    public class TextMessageHandler: IConsume<TextMessage>
    {
        public void Consume(TextMessage message)
        {
           //Code Hanldler ...
        }
    }
}
