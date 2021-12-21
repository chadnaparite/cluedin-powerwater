using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Powerwater;
using CluedIn.Crawling.Powerwater.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Powerwater.Unit.Test
{
    public class PowerwaterCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public PowerwaterCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IPowerwaterClientFactory>();

            _sut = new PowerwaterCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
