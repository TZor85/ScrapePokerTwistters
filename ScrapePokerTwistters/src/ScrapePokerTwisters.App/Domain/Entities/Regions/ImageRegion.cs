using System.Drawing;

namespace ScrapePokerTwisters.App.Domain.Entities.Regions
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
