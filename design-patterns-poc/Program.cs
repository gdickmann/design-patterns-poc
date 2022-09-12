using design_patterns_poc.Interfaces;
using design_patterns_poc.Interfaces.AbstractFactory;
using design_patterns_poc.Interfaces.AbstractFactory.Chair;
using design_patterns_poc.Interfaces.AbstractFactory.Modern;
using design_patterns_poc.Interfaces.AbstractFactory.Victorian;

namespace design_patterns_poc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Art Deco products: ");
            CreateArtDecoProducts();

            Console.WriteLine("Modern products: ");
            CreateModernProducts();

            Console.WriteLine("Victorian products: ");
            CreateVictorianProducts();
        }

        private static void CreateArtDecoProducts()
        {
            IFurnitureFactory factory = new ArtDecoFactory();

            IChair chair = factory.CreateChair();
            chair.SitOn();

            ICoffeTable coffeTable = factory.CreateCoffeTable();
            coffeTable.TurnOn();

            ISofa sofa = factory.CreateSofa();
            sofa.SitOn();
        }

        private static void CreateModernProducts()
        {
            IFurnitureFactory factory = new ModernFactory();

            IChair chair = factory.CreateChair();
            chair.SitOn();

            ICoffeTable coffeTable = factory.CreateCoffeTable();
            coffeTable.TurnOn();

            ISofa sofa = factory.CreateSofa();
            sofa.SitOn();
        }

        private static void CreateVictorianProducts()
        {
            IFurnitureFactory factory = new VictorianFactory();

            IChair chair = factory.CreateChair();
            chair.SitOn();

            ICoffeTable coffeTable = factory.CreateCoffeTable();
            coffeTable.TurnOn();

            ISofa sofa = factory.CreateSofa();
            sofa.SitOn();
        }
    }
}
