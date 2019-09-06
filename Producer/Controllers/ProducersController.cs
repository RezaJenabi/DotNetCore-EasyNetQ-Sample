using EasyNetQ;
using Messages;
using Microsoft.AspNetCore.Mvc;

namespace Publisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly IBus _bus;

        public ProducersController(IBus bus)
        {
            _bus = bus;
        }
        [HttpGet]
        [Route("Send")]
        public JsonResult Send()
        {

            _bus.Publish(new TextMessage { Text = "Send Message from the Producer" });

            return new JsonResult("");
        }

        
    }
}
