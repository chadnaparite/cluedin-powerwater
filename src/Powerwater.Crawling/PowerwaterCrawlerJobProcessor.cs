using CluedIn.Crawling.Powerwater.Core;

namespace CluedIn.Crawling.Powerwater
{
    public class PowerwaterCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<PowerwaterCrawlJobData>
    {
        public PowerwaterCrawlerJobProcessor(PowerwaterCrawlerComponent component) : base(component)
        {
        }
    }
}
