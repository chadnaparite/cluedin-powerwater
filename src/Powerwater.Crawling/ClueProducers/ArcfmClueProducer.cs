using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Powerwater.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Models;

namespace CluedIn.Crawling.Powerwater.ClueProducers
{
    public class ArcfmClueProducer : BaseClueProducer<Arcfm>
    {
        private readonly IClueFactory factory;

        public ArcfmClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Arcfm input, Guid accountId)
        {
            var arcfmVocabulary = new ArcfmVocabulary();
            var clue = factory.Create(arcfmVocabulary.Grouping, input.ObjectId.ToString(), accountId);

            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.ObjectId != null)
            {
                data.Name = input.ObjectId;
                data.DisplayName = input.ObjectId;
            }

            if (input.Description != null)
            {
                data.Description = input.Description;
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
            //     data.Properties[arcfmVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[arcfmVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[arcfmVocabulary.ObjectId] = input.ObjectId.PrintIfAvailable();
            data.Properties[arcfmVocabulary.AddressCode] = input.AddressCode.PrintIfAvailable();
            data.Properties[arcfmVocabulary.FromDate] = input.FromDate.PrintIfAvailable();
            data.Properties[arcfmVocabulary.ToDate] = input.ToDate.PrintIfAvailable();
            data.Properties[arcfmVocabulary.CadastreParcelKey] = input.CadastreParcelKey.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Parent] = input.Parent.PrintIfAvailable();
            data.Properties[arcfmVocabulary.TitleReference] = input.TitleReference.PrintIfAvailable();
            data.Properties[arcfmVocabulary.UnitPlanRef] = input.UnitPlanRef.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Locality] = input.Locality.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Name] = input.Name.PrintIfAvailable();
            data.Properties[arcfmVocabulary.ParcelNumber] = input.ParcelNumber.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Unit] = input.Unit.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StreetNumber] = input.StreetNumber.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StreetNumberPart] = input.StreetNumberPart.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StreetName] = input.StreetName.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StreetType] = input.StreetType.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Suburb] = input.Suburb.PrintIfAvailable();
            data.Properties[arcfmVocabulary.State] = input.State.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Postcode] = input.Postcode.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StreetAddress] = input.StreetAddress.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Description] = input.Description.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Directions] = input.Directions.PrintIfAvailable();
            data.Properties[arcfmVocabulary.AddressType] = input.AddressType.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Status] = input.Status.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Source] = input.Source.PrintIfAvailable();
            data.Properties[arcfmVocabulary.PrimaryFlag] = input.PrimaryFlag.PrintIfAvailable();
            data.Properties[arcfmVocabulary.PowerInstallFlag] = input.PowerInstallFlag.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WaterInstallFlag] = input.WaterInstallFlag.PrintIfAvailable();
            data.Properties[arcfmVocabulary.SewerInstallFlag] = input.SewerInstallFlag.PrintIfAvailable();
            data.Properties[arcfmVocabulary.UpdateFlag] = input.UpdateFlag.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StatusDate] = input.StatusDate.PrintIfAvailable();
            data.Properties[arcfmVocabulary.UpdateDate] = input.UpdateDate.PrintIfAvailable();
            data.Properties[arcfmVocabulary.UpdateUser] = input.UpdateUser.PrintIfAvailable();
            data.Properties[arcfmVocabulary.ReplacedAddressCode] = input.ReplacedAddressCode.PrintIfAvailable();
            data.Properties[arcfmVocabulary.OldWfRouteToPerson] = input.OldWfRouteToPerson.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Latitude] = input.Latitude.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Longitude] = input.Longitude.PrintIfAvailable();
            data.Properties[arcfmVocabulary.RowStamp] = input.RowStamp.PrintIfAvailable();
            data.Properties[arcfmVocabulary.Owner] = input.Owner.PrintIfAvailable();
            data.Properties[arcfmVocabulary.OldWfRouteToPersonGroup] = input.OldWfRouteToPersonGroup.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfEscalationDays] = input.WfEscalationDays.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfAction] = input.WfAction.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfInteractive] = input.WfInteractive.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfMemo] = input.WfMemo.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfMemolist] = input.WfMemolist.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfRouteToPerson] = input.WfRouteToPerson.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfRouteToPersonGroup] = input.WfRouteToPersonGroup.PrintIfAvailable();
            data.Properties[arcfmVocabulary.WfStatus] = input.WfStatus.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxOrgid] = input.MxOrgid.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxSiteId] = input.MxSiteId.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxStaddrdIrprfx] = input.MxStaddrdIrprfx.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxStaddrdIrsfx] = input.MxStaddrdIrsfx.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxRegionDistrict] = input.MxRegionDistrict.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxCounty] = input.MxCounty.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxStateProvince] = input.MxStateProvince.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxCountry] = input.MxCountry.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxGeocode] = input.MxGeocode.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxTimezone] = input.MxTimezone.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxReferencepoint] = input.MxReferencepoint.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxPlussFeatureClass] = input.MxPlussFeatureClass.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxPlussIsGis] = input.MxPlussIsGis.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxHasLd] = input.MxHasLd.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxLangCode] = input.MxLangCode.PrintIfAvailable();
            data.Properties[arcfmVocabulary.MxPlussServiceAddressId] = input.MxPlussServiceAddressId.PrintIfAvailable();
            data.Properties[arcfmVocabulary.StreetNumberPrefix] = input.StreetNumberPrefix.PrintIfAvailable();
            data.Properties[arcfmVocabulary.IsCadastreUnit] = input.IsCadastreUnit.PrintIfAvailable();
            data.Properties[arcfmVocabulary.UnitStreetNumberPrefix] = input.UnitStreetNumberPrefix.PrintIfAvailable();
            data.Properties[arcfmVocabulary.LtoCode] = input.LtoCode.PrintIfAvailable();

            return clue;
        }
    }
}
