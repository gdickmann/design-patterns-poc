using design_patterns_poc.Models.Chair;
using design_patterns_poc.Models.CoffeTable;
using design_patterns_poc.Models.Sofa;

namespace design_patterns_poc.Interfaces.AbstractFactory.Chair
{

    public class ArtDecoFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ArtDecoCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
