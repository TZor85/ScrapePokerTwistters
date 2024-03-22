namespace ScrapePokerTwisters.App.Domain.Entities.Regions
{
    public class Regions
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; } = 20;
        public int Height { get; set; } = 20;
        public string? Value { get; set; }
        public bool IsHash { get; set; }
        public bool IsColor { get; set; }
        public bool IsBoard { get; set; }
        public string? Color { get; set; }
    }
}
