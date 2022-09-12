using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.Chair
{
    public class ArtDecoChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("Art deco chair has legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Art deco chair sit on action.");
        }
    }
}
