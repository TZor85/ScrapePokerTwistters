namespace ScrapePokerTwisters.App.Domain.Entities.Regions
{
    public class FontRegion
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
}
