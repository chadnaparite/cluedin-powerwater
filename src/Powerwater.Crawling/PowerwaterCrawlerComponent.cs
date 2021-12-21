using CluedIn.Core;
using CluedIn.Crawling.Powerwater.Core;

using ComponentHost;

namespace CluedIn.Crawling.Powerwater
{
    [Component(PowerwaterConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class PowerwaterCrawlerComponent : CrawlerComponentBase
    {
        public PowerwaterCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

