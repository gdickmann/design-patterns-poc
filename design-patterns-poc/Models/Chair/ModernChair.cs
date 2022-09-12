using design_patterns_poc.Interfaces;

namespace design_patterns_poc.Models.Chair
{
    public class ModernChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("Modern chair sit has legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Modern chair sit on action.");
        }
    }
}
