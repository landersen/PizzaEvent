namespace PizzaEventService.Model
{
    public class Event
    {
        public String bordNummer { get; set; }
        public int pizzaNummer { get; set; }

        public Event(string bordNummer, int pizzaNummer)
        {
            this.bordNummer = bordNummer;
            this.pizzaNummer = pizzaNummer;
        }
    }
}
