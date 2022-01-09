using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Powerwater.ClueProducers;
using CluedIn.Crawling.Powerwater.Core.Models;

namespace Crawling.Powerwater.Unit.Test.ClueProducers
{
    public class LocationClueProducerTests : BaseClueProducerTest<Location>
    {
        protected override BaseClueProducer<Location> Sut =>
            new LocationClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Location.Address;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Location location)
        {
            var clue = Sut.MakeClue(location, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
