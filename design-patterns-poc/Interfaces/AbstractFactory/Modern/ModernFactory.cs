using design_patterns_poc.Models.Chair;
using design_patterns_poc.Models.CoffeTable;
using design_patterns_poc.Models.Sofa;

namespace design_patterns_poc.Interfaces.AbstractFactory.Modern
{
    public class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ModernCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
