using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.CoffeTable
{
    public class VictorianCoffeTable : ICoffeTable
    {
        public void TurnOff()
        {
            Console.WriteLine("Victorian coffe table turn off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Victorian coffe table turn on.");
        }
    }
}
