using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Powerwater.ClueProducers;
using CluedIn.Crawling.Powerwater.Core.Models;
using CluedIn.Crawling.Powerwater.Core.Constants;

namespace Crawling.Powerwater.Unit.Test.ClueProducers
{
    public class ArcfmClueProducerTests : BaseClueProducerTest<Arcfm>
    {
        protected override BaseClueProducer<Arcfm> Sut =>
            new ArcfmClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => PowerwaterEntities.Arcfm;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Arcfm arcfm)
        {
            var clue = Sut.MakeClue(arcfm, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
