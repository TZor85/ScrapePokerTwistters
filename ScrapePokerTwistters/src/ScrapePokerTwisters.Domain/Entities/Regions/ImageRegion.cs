using System.Drawing;

namespace ScrapePokerTwisters.Domain.Entities.Regions
{
    public class ImageRegion
    {
        public string? Name { get; set; }
        public Bitmap? Image { get; set; }
        public bool IsBoard { get; set; }
        public string? Value { get; set; }
        public int Force { get; set; }
        public int Suit { get; set; }
    }
}
