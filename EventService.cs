using PizzaEventService.Model;

namespace PizzaEventService
{
    public class EventService
    {
        private static readonly Dictionary<int, Event> db = new Dictionary<int, Event>();
        private Dictionary<int, string> menuKort = new Dictionary<int, string>()
        {
            {0, "Margherita" },
            {1, "Vesuvio" },
            {2, "Pepperoni" },
            {3, "Hawaii" },
            {4, "Roma" },
            {5, "Pollo" },
            {6, "Bari" },
            {7, "Kebab" },
            {8, "Smartlearning" },
            {9, "Java" },
            {10, "cSharp" }
        };

        public string Gem(Event model)
        {
            // hvis man spørger på en id, som ikke findes på menukortet
            if (model.pizzaNummer > menuKort.Count)
            {
                return "pizza nr. " + model.pizzaNummer + " findes ikke";
            }

            string pizza = menuKort[model.pizzaNummer];
            if (pizza == null) 
            { 
                return "Pizza nummer findes ikke"; 
            }

            // Tilføj til db
            // db.count +1 tæller 1 op ligesom et løbenr.
            // ved brug af løbenr - gør også at samme bord, kan have flere bestillinger.
            db.Add(db.Count+1, model);

            return "din " + pizza + " er nu gemt";
        }

        public Event Find(int id)
        {
            // Find event ud fra id i db.
            return db[id];
        }
    }
}
