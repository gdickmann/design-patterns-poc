namespace design_patterns_poc.Interfaces.AbstractFactory
{
    public interface IFurnitureFactory
    {

        IChair CreateChair();
        ICoffeTable CreateCoffeTable();
        ISofa CreateSofa();

    }
}
