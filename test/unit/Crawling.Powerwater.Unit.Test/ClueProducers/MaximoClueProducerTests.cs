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
    public class MaximoClueProducerTests : BaseClueProducerTest<Maximo>
    {
        protected override BaseClueProducer<Maximo> Sut =>
            new MaximoClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => PowerwaterEntities.Maximo;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Maximo maximo)
        {
            var clue = Sut.MakeClue(maximo, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
