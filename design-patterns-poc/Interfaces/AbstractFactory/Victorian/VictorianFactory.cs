using design_patterns_poc.Models.Chair;
using design_patterns_poc.Models.CoffeTable;
using design_patterns_poc.Models.Sofa;

namespace design_patterns_poc.Interfaces.AbstractFactory.Victorian
{
    public class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
