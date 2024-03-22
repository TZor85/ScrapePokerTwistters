using ScrapePokerTwisters.App.Domain.Entities.Regions;

namespace ScrapePokerTwisters.App.Interfaces
{
    public interface IAddRegion
    {
        void Execute(string texto, string nodo);
        void Execute(List<FontRegion> fonts);
    }
}
