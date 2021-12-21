using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Powerwater.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Models;

namespace CluedIn.Crawling.Powerwater.ClueProducers
{
    public class MaximoClueProducer : BaseClueProducer<Maximo>
    {
        private readonly IClueFactory factory;

        public MaximoClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Maximo input, Guid accountId)
        {
            var maximoVocabulary = new MaximoVocabulary();
            var clue = factory.Create(maximoVocabulary.Grouping, input.Location.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.Location != null)
            {
                data.Name = input.Location;
                data.DisplayName = input.Location;
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
            //     data.Properties[maximoVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[maximoVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[maximoVocabulary.Location] = input.Location.PrintIfAvailable();
            data.Properties[maximoVocabulary.Description] = input.Description.PrintIfAvailable();
            data.Properties[maximoVocabulary.Type] = input.Type.PrintIfAvailable();
            data.Properties[maximoVocabulary.ControlAcc] = input.ControlAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.GlAccount] = input.GlAccount.PrintIfAvailable();
            data.Properties[maximoVocabulary.PurchVarAcc] = input.PurchVarAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.InvoiceVarAcc] = input.InvoiceVarAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.CurVarAcc] = input.CurVarAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.ShrinkAgeAcc] = input.ShrinkAgeAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.InvCostAdjAcc] = input.InvCostAdjAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.ReceiptVarAcc] = input.ReceiptVarAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.ChangeBy] = input.ChangeBy.PrintIfAvailable();
            data.Properties[maximoVocabulary.ChangeDate] = input.ChangeDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.Disabled] = input.Disabled.PrintIfAvailable();
            data.Properties[maximoVocabulary.OldControlAcc] = input.OldControlAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.OldShrinkAgeAcc] = input.OldShrinkAgeAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.OldInvCostAdjacc] = input.OldInvCostAdjacc.PrintIfAvailable();
            data.Properties[maximoVocabulary.ClassStructureId] = input.ClassStructureId.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisParam1] = input.GisParam1.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisParam2] = input.GisParam2.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisParam3] = input.GisParam3.PrintIfAvailable();
            data.Properties[maximoVocabulary.SourceSysId] = input.SourceSysId.PrintIfAvailable();
            data.Properties[maximoVocabulary.OwnerSysId] = input.OwnerSysId.PrintIfAvailable();
            data.Properties[maximoVocabulary.ExternalRefId] = input.ExternalRefId.PrintIfAvailable();
            data.Properties[maximoVocabulary.SenderSysId] = input.SenderSysId.PrintIfAvailable();
            data.Properties[maximoVocabulary.SiteId] = input.SiteId.PrintIfAvailable();
            data.Properties[maximoVocabulary.OrgId] = input.OrgId.PrintIfAvailable();
            data.Properties[maximoVocabulary.IntLabRec] = input.IntLabRec.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsDefault] = input.IsDefault.PrintIfAvailable();
            data.Properties[maximoVocabulary.ShipToAddressCode] = input.ShipToAddressCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.ShipToLaborCode] = input.ShipToLaborCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.BillToAddressCode] = input.BillToAddressCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.BillToLaborCode] = input.BillToLaborCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.Status] = input.Status.PrintIfAvailable();
            data.Properties[maximoVocabulary.ServiceAddressCode] = input.ServiceAddressCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocationSid] = input.LocationSid.PrintIfAvailable();
            data.Properties[maximoVocabulary.UseInPopr] = input.UseInPopr.PrintIfAvailable();
            data.Properties[maximoVocabulary.ToolControlAcc] = input.ToolControlAcc.PrintIfAvailable();
            data.Properties[maximoVocabulary.LangCode] = input.LangCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.Hasld] = input.Hasld.PrintIfAvailable();
            data.Properties[maximoVocabulary.AutoWogen] = input.AutoWogen.PrintIfAvailable();
            data.Properties[maximoVocabulary.StatusDate] = input.StatusDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsFacility] = input.IsFacility.PrintIfAvailable();
            data.Properties[maximoVocabulary.Facility] = input.Facility.PrintIfAvailable();
            data.Properties[maximoVocabulary.Area] = input.Area.PrintIfAvailable();
            data.Properties[maximoVocabulary.Alias] = input.Alias.PrintIfAvailable();
            data.Properties[maximoVocabulary.InstalledDate] = input.InstalledDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.InstalledBy] = input.InstalledBy.PrintIfAvailable();
            data.Properties[maximoVocabulary.Owner] = input.Owner.PrintIfAvailable();
            data.Properties[maximoVocabulary.BusinessUnit] = input.BusinessUnit.PrintIfAvailable();
            data.Properties[maximoVocabulary.Community] = input.Community.PrintIfAvailable();
            data.Properties[maximoVocabulary.Department] = input.Department.PrintIfAvailable();
            data.Properties[maximoVocabulary.Service] = input.Service.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussFeatureClass] = input.PlussFeatureClass.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussIsGis] = input.PlussIsGis.PrintIfAvailable();
            data.Properties[maximoVocabulary.RowStamp] = input.RowStamp.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussAddressCode] = input.PlussAddressCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussDescription] = input.PlussDescription.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStaddrNumber] = input.PlussStaddrNumber.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStaddrDirPrfx] = input.PlussStaddrDirPrfx.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStaddrStreet] = input.PlussStaddrStreet.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStaddrSttype] = input.PlussStaddrSttype.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStaddrDirSfx] = input.PlussStaddrDirSfx.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStaddrUnitNum] = input.PlussStaddrUnitNum.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStreetAddress] = input.PlussStreetAddress.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussAddressLine2] = input.PlussAddressLine2.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussAddressLine3] = input.PlussAddressLine3.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussCity] = input.PlussCity.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussRegionDistrict] = input.PlussRegionDistrict.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussCounty] = input.PlussCounty.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussStateProvince] = input.PlussStateProvince.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussPostalCode] = input.PlussPostalCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussCountry] = input.PlussCountry.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussGeocode] = input.PlussGeocode.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussTimezone] = input.PlussTimezone.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussLatitude] = input.PlussLatitude.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussLongitude] = input.PlussLongitude.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussReferencePoint] = input.PlussReferencePoint.PrintIfAvailable();
            data.Properties[maximoVocabulary.PlussDirections] = input.PlussDirections.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsAutoIssueParts] = input.IsAutoIssueParts.PrintIfAvailable();
            data.Properties[maximoVocabulary.AutoIssueLeadTime] = input.AutoIssueLeadTime.PrintIfAvailable();
            data.Properties[maximoVocabulary.AutoIssueStatus] = input.AutoIssueStatus.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsVehicle] = input.IsVehicle.PrintIfAvailable();
            data.Properties[maximoVocabulary.Vendor] = input.Vendor.PrintIfAvailable();
            data.Properties[maximoVocabulary.PluscDueDate] = input.PluscDueDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.PluscLoop] = input.PluscLoop.PrintIfAvailable();
            data.Properties[maximoVocabulary.PluscPmextDate] = input.PluscPmextDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsRecloser] = input.IsRecloser.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsFeeder] = input.IsFeeder.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsSubStation] = input.IsSubStation.PrintIfAvailable();
            data.Properties[maximoVocabulary.FeederId] = input.FeederId.PrintIfAvailable();
            data.Properties[maximoVocabulary.SubStationId] = input.SubStationId.PrintIfAvailable();
            data.Properties[maximoVocabulary.RecloserId] = input.RecloserId.PrintIfAvailable();
            data.Properties[maximoVocabulary.System] = input.System.PrintIfAvailable();
            data.Properties[maximoVocabulary.SystemType] = input.SystemType.PrintIfAvailable();
            data.Properties[maximoVocabulary.Maintainer] = input.Maintainer.PrintIfAvailable();
            data.Properties[maximoVocabulary.ScadaId] = input.ScadaId.PrintIfAvailable();
            data.Properties[maximoVocabulary.FisLegacyId] = input.FisLegacyId.PrintIfAvailable();
            data.Properties[maximoVocabulary.WimsLegacyId] = input.WimsLegacyId.PrintIfAvailable();
            data.Properties[maximoVocabulary.WfRouteToPerson] = input.WfRouteToPerson.PrintIfAvailable();
            data.Properties[maximoVocabulary.WfRouteToPersonGroup] = input.WfRouteToPersonGroup.PrintIfAvailable();
            data.Properties[maximoVocabulary.WfInteractive] = input.WfInteractive.PrintIfAvailable();
            data.Properties[maximoVocabulary.OldWfRouteToPerson] = input.OldWfRouteToPerson.PrintIfAvailable();
            data.Properties[maximoVocabulary.OldWfRouteToPersonGroup] = input.OldWfRouteToPersonGroup.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommunityEnglishName] = input.CommunityEnglishName.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommunityName] = input.CommunityName.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommunityTradition] = input.CommunityTradition.PrintIfAvailable();
            data.Properties[maximoVocabulary.EntryCondition] = input.EntryCondition.PrintIfAvailable();
            data.Properties[maximoVocabulary.Erp] = input.Erp.PrintIfAvailable();
            data.Properties[maximoVocabulary.SpecificationDescription] = input.SpecificationDescription.PrintIfAvailable();
            data.Properties[maximoVocabulary.AssetBusinessUnit] = input.AssetBusinessUnit.PrintIfAvailable();
            data.Properties[maximoVocabulary.AssetDepartment] = input.AssetDepartment.PrintIfAvailable();
            data.Properties[maximoVocabulary.AssetGroup] = input.AssetGroup.PrintIfAvailable();
            data.Properties[maximoVocabulary.AssetOwner] = input.AssetOwner.PrintIfAvailable();
            data.Properties[maximoVocabulary.CatchmentMajor] = input.CatchmentMajor.PrintIfAvailable();
            data.Properties[maximoVocabulary.CatchmentMinor] = input.CatchmentMinor.PrintIfAvailable();
            data.Properties[maximoVocabulary.CatchmentZone] = input.CatchmentZone.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommissionDate] = input.CommissionDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommunityAcronym] = input.CommunityAcronym.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommunityAlias] = input.CommunityAlias.PrintIfAvailable();
            data.Properties[maximoVocabulary.CommunityId] = input.CommunityId.PrintIfAvailable();
            data.Properties[maximoVocabulary.CriticalCustomer] = input.CriticalCustomer.PrintIfAvailable();
            data.Properties[maximoVocabulary.DecommissionDate] = input.DecommissionDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisGlobalId] = input.GisGlobalId.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocArea] = input.LocArea.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocCommunity] = input.LocCommunity.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocRegion] = input.LocRegion.PrintIfAvailable();
            data.Properties[maximoVocabulary.MaintainerBusinessUnit] = input.MaintainerBusinessUnit.PrintIfAvailable();
            data.Properties[maximoVocabulary.MaintainerDepartment] = input.MaintainerDepartment.PrintIfAvailable();
            data.Properties[maximoVocabulary.MaintainerGroup] = input.MaintainerGroup.PrintIfAvailable();
            data.Properties[maximoVocabulary.PendingEdit] = input.PendingEdit.PrintIfAvailable();
            data.Properties[maximoVocabulary.WaterSystem] = input.WaterSystem.PrintIfAvailable();
            data.Properties[maximoVocabulary.WfEscalationDays] = input.WfEscalationDays.PrintIfAvailable();
            data.Properties[maximoVocabulary.WfMemoList] = input.WfMemoList.PrintIfAvailable();
            data.Properties[maximoVocabulary.WfStatus] = input.WfStatus.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocationCode] = input.LocationCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.FisLegacyTbName] = input.FisLegacyTbName.PrintIfAvailable();
            data.Properties[maximoVocabulary.Locality] = input.Locality.PrintIfAvailable();
            data.Properties[maximoVocabulary.Rdspp] = input.Rdspp.PrintIfAvailable();
            data.Properties[maximoVocabulary.SubUrb] = input.SubUrb.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisErrorMessage] = input.GisErrorMessage.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisProcessedDate] = input.GisProcessedDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.DogCode] = input.DogCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.CriticalCode] = input.CriticalCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.CriticalFlag] = input.CriticalFlag.PrintIfAvailable();
            data.Properties[maximoVocabulary.CustomerCode] = input.CustomerCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.ConsumerCode] = input.ConsumerCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.ServiceEnduse] = input.ServiceEnduse.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsThreateningCustomer] = input.IsThreateningCustomer.PrintIfAvailable();
            data.Properties[maximoVocabulary.DisconnectDate] = input.DisconnectDate.PrintIfAvailable();
            data.Properties[maximoVocabulary.MeterLocationCode] = input.MeterLocationCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.MeterRemarks] = input.MeterRemarks.PrintIfAvailable();
            data.Properties[maximoVocabulary.TenantCode] = input.TenantCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisServiceName] = input.GisServiceName.PrintIfAvailable();
            data.Properties[maximoVocabulary.MultipleAssets] = input.MultipleAssets.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocClassificationId] = input.LocClassificationId.PrintIfAvailable();
            data.Properties[maximoVocabulary.ClasssHortCode] = input.ClasssHortCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsPvMeter] = input.IsPvMeter.PrintIfAvailable();
            data.Properties[maximoVocabulary.KeyNumber] = input.KeyNumber.PrintIfAvailable();
            data.Properties[maximoVocabulary.MeterPostion] = input.MeterPostion.PrintIfAvailable();
            data.Properties[maximoVocabulary.PrePaymentMeter] = input.PrePaymentMeter.PrintIfAvailable();
            data.Properties[maximoVocabulary.Restrictorapplied] = input.Restrictorapplied.PrintIfAvailable();
            data.Properties[maximoVocabulary.RetailerCode] = input.RetailerCode.PrintIfAvailable();
            data.Properties[maximoVocabulary.UndergroundNetwork] = input.UndergroundNetwork.PrintIfAvailable();
            data.Properties[maximoVocabulary.CustomerFeeder] = input.CustomerFeeder.PrintIfAvailable();
            data.Properties[maximoVocabulary.FeederCategory] = input.FeederCategory.PrintIfAvailable();
            data.Properties[maximoVocabulary.InstallCount] = input.InstallCount.PrintIfAvailable();
            data.Properties[maximoVocabulary.LengthInMetres] = input.LengthInMetres.PrintIfAvailable();
            data.Properties[maximoVocabulary.NominalkVaLoad] = input.NominalkVaLoad.PrintIfAvailable();
            data.Properties[maximoVocabulary.Voltage] = input.Voltage.PrintIfAvailable();
            data.Properties[maximoVocabulary.AreaInSquareMetres] = input.AreaInSquareMetres.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisSubType] = input.GisSubType.PrintIfAvailable();
            data.Properties[maximoVocabulary.PressureZoneId] = input.PressureZoneId.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisLocTemp] = input.GisLocTemp.PrintIfAvailable();
            data.Properties[maximoVocabulary.IsTestLocation] = input.IsTestLocation.PrintIfAvailable();
            data.Properties[maximoVocabulary.DecomStore] = input.DecomStore.PrintIfAvailable();
            data.Properties[maximoVocabulary.GisPreventParentUpdate] = input.GisPreventParentUpdate.PrintIfAvailable();
            data.Properties[maximoVocabulary.ManualFeederId] = input.ManualFeederId.PrintIfAvailable();
            data.Properties[maximoVocabulary.AerFeeder] = input.AerFeeder.PrintIfAvailable();
            data.Properties[maximoVocabulary.LocationSyncId] = input.LocationSyncId.PrintIfAvailable();

            return clue;
        }
    }
}
