using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Constants;

namespace CluedIn.Crawling.Powerwater.Vocabularies
{
    public class  ArcfmVocabulary : SimpleVocabulary
    {
        public  ArcfmVocabulary()
        {
            VocabularyName = "Powerwater Arcfm"; 
            KeyPrefix      = "powerwater.arcfm"; 
            KeySeparator   = ".";
            Grouping       = PowerwaterEntities.Arcfm; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Powerwater Arcfm Details", group =>
            {
                ObjectId = group.Add(new VocabularyKey("ObjectId", "Object Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCode = group.Add(new VocabularyKey("AddressCode", "Address Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey("FromDate", "From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey("ToDate", "To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CadastreParcelKey = group.Add(new VocabularyKey("CadastreParcelKey", "Cadastre Parcel Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Parent = group.Add(new VocabularyKey("Parent", "Parent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TitleReference = group.Add(new VocabularyKey("TitleReference", "Title Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPlanRef = group.Add(new VocabularyKey("UnitPlanRef", "Unit Plan Ref", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Locality = group.Add(new VocabularyKey("Locality", "Locality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey("Name", "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParcelNumber = group.Add(new VocabularyKey("ParcelNumber", "Parcel Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey("Unit", "Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey("StreetNumber", "Street Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumberPart = group.Add(new VocabularyKey("StreetNumberPart", "Street Number Part", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetName = group.Add(new VocabularyKey("StreetName", "Street Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetType = group.Add(new VocabularyKey("StreetType", "Street Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Suburb = group.Add(new VocabularyKey("Suburb", "Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Postcode = group.Add(new VocabularyKey("Postcode", "Postcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetAddress = group.Add(new VocabularyKey("StreetAddress", "Street Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Directions = group.Add(new VocabularyKey("Directions", "Directions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressType = group.Add(new VocabularyKey("AddressType", "Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey("Status", "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Source = group.Add(new VocabularyKey("Source", "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFlag = group.Add(new VocabularyKey("PrimaryFlag", "Primary Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PowerInstallFlag = group.Add(new VocabularyKey("PowerInstallFlag", "Power Install Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaterInstallFlag = group.Add(new VocabularyKey("WaterInstallFlag", "Water Install Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SewerInstallFlag = group.Add(new VocabularyKey("SewerInstallFlag", "Sewer Install Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateFlag = group.Add(new VocabularyKey("UpdateFlag", "Update Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusDate = group.Add(new VocabularyKey("StatusDate", "Status Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateDate = group.Add(new VocabularyKey("UpdateDate", "Update Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateUser = group.Add(new VocabularyKey("UpdateUser", "Update User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacedAddressCode = group.Add(new VocabularyKey("ReplacedAddressCode", "Replaced Address Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldWfRouteToPerson = group.Add(new VocabularyKey("OldWfRouteToPerson", "Old Wf Route To Person", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Latitude = group.Add(new VocabularyKey("Latitude", "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Longitude = group.Add(new VocabularyKey("Longitude", "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowStamp = group.Add(new VocabularyKey("RowStamp", "Row Stamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey("Owner", "Owner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldWfRouteToPersonGroup = group.Add(new VocabularyKey("OldWfRouteToPersonGroup", "Old Wf Route To Person Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfEscalationDays = group.Add(new VocabularyKey("WfEscalationDays", "Wf Escalation Days", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfAction = group.Add(new VocabularyKey("WfAction", "Wf Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfInteractive = group.Add(new VocabularyKey("WfInteractive", "Wf Interactive", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfMemo = group.Add(new VocabularyKey("WfMemo", "Wf Memo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfMemolist = group.Add(new VocabularyKey("WfMemolist", "Wf Memolist", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfRouteToPerson = group.Add(new VocabularyKey("WfRouteToPerson", "Wf Route To Person", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfRouteToPersonGroup = group.Add(new VocabularyKey("WfRouteToPersonGroup", "Wf Route To Person Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfStatus = group.Add(new VocabularyKey("WfStatus", "Wf Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxOrgid = group.Add(new VocabularyKey("MxOrgid", "Mx Orgid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxSiteId = group.Add(new VocabularyKey("MxSiteId", "Mx Site Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxStaddrdIrprfx = group.Add(new VocabularyKey("MxStaddrdIrprfx", "Mx Staddrd Irprfx", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxStaddrdIrsfx = group.Add(new VocabularyKey("MxStaddrdIrsfx", "Mx Staddrd Irsfx", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxRegionDistrict = group.Add(new VocabularyKey("MxRegionDistrict", "Mx Region District", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxCounty = group.Add(new VocabularyKey("MxCounty", "Mx County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxStateProvince = group.Add(new VocabularyKey("MxStateProvince", "Mx State Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxCountry = group.Add(new VocabularyKey("MxCountry", "Mx Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxGeocode = group.Add(new VocabularyKey("MxGeocode", "Mx Geocode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxTimezone = group.Add(new VocabularyKey("MxTimezone", "Mx Timezone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxReferencepoint = group.Add(new VocabularyKey("MxReferencepoint", "Mx Referencepoint", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxPlussFeatureClass = group.Add(new VocabularyKey("MxPlussFeatureClass", "Mx Pluss Feature Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxPlussIsGis = group.Add(new VocabularyKey("MxPlussIsGis", "Mx Pluss Is Gis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxHasLd = group.Add(new VocabularyKey("MxHasLd", "Mx Has Ld", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxLangCode = group.Add(new VocabularyKey("MxLangCode", "Mx Lang Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MxPlussServiceAddressId = group.Add(new VocabularyKey("MxPlussServiceAddressId", "Mx Pluss Service Address Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumberPrefix = group.Add(new VocabularyKey("StreetNumberPrefix", "Street Number Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCadastreUnit = group.Add(new VocabularyKey("IsCadastreUnit", "Is Cadastre Unit?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitStreetNumberPrefix = group.Add(new VocabularyKey("UnitStreetNumberPrefix", "Unit Street Number Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LtoCode = group.Add(new VocabularyKey("LtoCode", "Lto Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.

            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
            AddMapping(StreetNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressStreetNumber);
            AddMapping(StreetName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
            AddMapping(Suburb, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressCity);
        }
        public VocabularyKey ObjectId { get; private set; }
        public VocabularyKey AddressCode { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey CadastreParcelKey { get; private set; }
        public VocabularyKey Parent { get; private set; }
        public VocabularyKey TitleReference { get; private set; }
        public VocabularyKey UnitPlanRef { get; private set; }
        public VocabularyKey Locality { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ParcelNumber { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey StreetNumberPart { get; private set; }
        public VocabularyKey StreetName { get; private set; }
        public VocabularyKey StreetType { get; private set; }
        public VocabularyKey Suburb { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Postcode { get; private set; }
        public VocabularyKey StreetAddress { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Directions { get; private set; }
        public VocabularyKey AddressType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey PrimaryFlag { get; private set; }
        public VocabularyKey PowerInstallFlag { get; private set; }
        public VocabularyKey WaterInstallFlag { get; private set; }
        public VocabularyKey SewerInstallFlag { get; private set; }
        public VocabularyKey UpdateFlag { get; private set; }
        public VocabularyKey StatusDate { get; private set; }
        public VocabularyKey UpdateDate { get; private set; }
        public VocabularyKey UpdateUser { get; private set; }
        public VocabularyKey ReplacedAddressCode { get; private set; }
        public VocabularyKey OldWfRouteToPerson { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey RowStamp { get; private set; }
        public VocabularyKey Owner { get; private set; }
        public VocabularyKey OldWfRouteToPersonGroup { get; private set; }
        public VocabularyKey WfEscalationDays { get; private set; }
        public VocabularyKey WfAction { get; private set; }
        public VocabularyKey WfInteractive { get; private set; }
        public VocabularyKey WfMemo { get; private set; }
        public VocabularyKey WfMemolist { get; private set; }
        public VocabularyKey WfRouteToPerson { get; private set; }
        public VocabularyKey WfRouteToPersonGroup { get; private set; }
        public VocabularyKey WfStatus { get; private set; }
        public VocabularyKey MxOrgid { get; private set; }
        public VocabularyKey MxSiteId { get; private set; }
        public VocabularyKey MxStaddrdIrprfx { get; private set; }
        public VocabularyKey MxStaddrdIrsfx { get; private set; }
        public VocabularyKey MxRegionDistrict { get; private set; }
        public VocabularyKey MxCounty { get; private set; }
        public VocabularyKey MxStateProvince { get; private set; }
        public VocabularyKey MxCountry { get; private set; }
        public VocabularyKey MxGeocode { get; private set; }
        public VocabularyKey MxTimezone { get; private set; }
        public VocabularyKey MxReferencepoint { get; private set; }
        public VocabularyKey MxPlussFeatureClass { get; private set; }
        public VocabularyKey MxPlussIsGis { get; private set; }
        public VocabularyKey MxHasLd { get; private set; }
        public VocabularyKey MxLangCode { get; private set; }
        public VocabularyKey MxPlussServiceAddressId { get; private set; }
        public VocabularyKey StreetNumberPrefix { get; private set; }
        public VocabularyKey IsCadastreUnit { get; private set; }
        public VocabularyKey UnitStreetNumberPrefix { get; private set; }
        public VocabularyKey LtoCode { get; private set; }
    }
}
