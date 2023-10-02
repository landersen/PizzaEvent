using Microsoft.AspNetCore.Mvc;
using PizzaEventService.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaEventService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventServiceController : ControllerBase
    {
        private EventService service = new EventService();

        /*
Din event-service skal kunne håndtere, at der kommer nye ordrer ind i et bestillingssystem på et pizzeria. 
Hver bestilling består af et bordnummer og nummeret på en pizza fra menukortet. 
Hvis et bord bestiller flere pizzaer, bliver det til flere bestilinger - hver bestilling består altså af netop én pizza.
Der raises en ny event, når der kommer en bestilling, og servicen skal give mulighed for at man kan hente events.
         */

        // GET api/<PizzaEventService>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return service.Find(id);
        }

        // POST api/<PizzaEventService>
        /*
{
	"tableNumber" : "Admin",
	"pizzaNumber" : 36,
}
         */
        [HttpPost]
        public string Post(Event value)
        {
            if (value == null) { return "Bad request"; }

            return service.Gem(value);
        }

    }
}
