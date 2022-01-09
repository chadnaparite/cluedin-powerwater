using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Powerwater.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Models;

namespace CluedIn.Crawling.Powerwater.ClueProducers
{
    public class LocationClueProducer : BaseClueProducer<Location>
    {
        private readonly IClueFactory factory;

        public LocationClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Location input, Guid accountId)
        {
            var locationVocabulary = new LocationVocabulary();
            var clue = factory.Create(locationVocabulary.Grouping, input.FullName.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }



            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }


            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[locationVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[locationVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }


            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, PowerwaterConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, PowerwaterConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[locationVocabulary.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetNumber] = input.StreetNumber.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetName] = input.StreetName.PrintIfAvailable();
            data.Properties[locationVocabulary.City] = input.City.PrintIfAvailable();

            return clue;
        }
    }
}
