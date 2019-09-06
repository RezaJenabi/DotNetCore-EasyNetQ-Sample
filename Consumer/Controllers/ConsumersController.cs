using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using Messages;
using Microsoft.AspNetCore.Mvc;

namespace Subscriber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumersController : ControllerBase, IConsume<TextMessage>
    {
        [HttpGet]
        [Route("Receive")]
        public JsonResult Receive()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Subscribe<TextMessage>("test", HandleTextMessage);
            }
            return new JsonResult("");
        }


        private static void HandleTextMessage(TextMessage textMessage)
        {
            var item = textMessage.Text;
        }

        public void Consume(TextMessage message)
        {
            //
        }
    }
}
