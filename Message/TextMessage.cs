using System.Collections.Generic;
using EasyNetQ;

namespace Messages
{
    [Queue("Qka.Client", ExchangeName = "Qka.Client")]
    public class TextMessage
    {
        public string Text { get; set; }
    }
}
