using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.Chair
{
    public class VictorianChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("Victorian chair has legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Victorian chair sit on action.");
        }
    }
}
