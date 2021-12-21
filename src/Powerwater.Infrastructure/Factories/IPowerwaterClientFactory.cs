using CluedIn.Crawling.Powerwater.Core;

namespace CluedIn.Crawling.Powerwater.Infrastructure.Factories
{
    public interface IPowerwaterClientFactory
    {
        PowerwaterClient CreateNew(PowerwaterCrawlJobData PowerwaterCrawlJobData);
    }
}
