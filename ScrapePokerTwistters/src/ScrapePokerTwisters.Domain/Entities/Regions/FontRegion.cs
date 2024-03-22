using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapePokerTwisters.Domain.Entities.Regions
{
    public class FontRegion
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
}
