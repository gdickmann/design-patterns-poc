using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.Sofa
{
    public class ModernSofa : ISofa
    {
        public void HasLegs()
        {
            Console.WriteLine("Modern sofa has legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Modern sofa sit on action.");
        }
    }
}
