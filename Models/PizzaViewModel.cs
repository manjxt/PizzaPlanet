namespace PizzaPlanet.Models
{
    public class PizzaViewModel
    {
        
            public List<Pizza> Pizzas { get; set; }
            public Dictionary<int, int> PizzaQuantities { get; set; } // LaptopId -> Quantity
        

    }
}

