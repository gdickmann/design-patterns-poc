using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.CoffeTable
{
    public class ArtDecoCoffeTable : ICoffeTable
    {

        public void TurnOff()
        {
            Console.WriteLine("Art deco coffe table turn off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Art deco coffe table turn on.");
        }
    }
}
