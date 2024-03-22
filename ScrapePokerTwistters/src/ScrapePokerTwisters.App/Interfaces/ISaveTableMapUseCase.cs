using ScrapePokerTwisters.App.Domain.Entities.Regions;

namespace ScrapePokerTwisters.App.Interfaces
{
    public class SaveTableMapUseCaseRequest
    {
        public string Key { get; set; } = string.Empty;
        public List<Regions> Regions { get; set; } = new List<Regions>();
        public List<ImageRegion> Images { get; set; } = new List<ImageRegion>();
        public List<ImageRegion> Board { get; set; } = new List<ImageRegion>();
        public List<FontRegion> Fonts { get; set; } = new List<FontRegion>();
    }

    public interface ISaveTableMapUseCase
    {
        void Execute(SaveTableMapUseCaseRequest request);
    }
}
