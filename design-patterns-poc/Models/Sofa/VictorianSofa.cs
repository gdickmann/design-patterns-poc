using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.Sofa
{
    public class VictorianSofa : ISofa
    {
        public void HasLegs()
        {
            Console.WriteLine("Victorian sofa has legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Victorian sofa sit on action.");
        }
    }
}
