using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Powerwater.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Powerwater.Unit.Test.PowerwaterProvider
{
    public abstract class PowerwaterProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IPowerwaterClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected PowerwaterProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IPowerwaterClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Powerwater.PowerwaterProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
