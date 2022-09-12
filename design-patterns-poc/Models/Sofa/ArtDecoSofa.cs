using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.Sofa
{
    public class ArtDecoSofa : ISofa
    {
        public void HasLegs()
        {
            Console.WriteLine("Art deco sofa has legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Art deco sofa sit on action.");
        }
    }
}
