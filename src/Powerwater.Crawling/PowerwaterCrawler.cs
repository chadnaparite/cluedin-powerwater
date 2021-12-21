using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Powerwater.Core;
using CluedIn.Crawling.Powerwater.Infrastructure.Factories;

namespace CluedIn.Crawling.Powerwater
{
    public class PowerwaterCrawler : ICrawlerDataGenerator
    {
        private readonly IPowerwaterClientFactory clientFactory;
        public PowerwaterCrawler(IPowerwaterClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is PowerwaterCrawlJobData PowerwatercrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(PowerwatercrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
