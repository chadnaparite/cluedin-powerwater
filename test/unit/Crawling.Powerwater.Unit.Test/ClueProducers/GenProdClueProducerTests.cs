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
    public class GenProdClueProducerTests : BaseClueProducerTest<GenProd>
    {
        protected override BaseClueProducer<GenProd> Sut =>
            new GenProdClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => PowerwaterEntities.GenProd;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(GenProd genprod)
        {
            var clue = Sut.MakeClue(genprod, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
