using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Constants;

namespace CluedIn.Crawling.Powerwater.Vocabularies
{
    public class  MaximoVocabulary : SimpleVocabulary
    {
        public  MaximoVocabulary()
        {
            VocabularyName = "Powerwater Maximo"; 
            KeyPrefix      = "powerwater.maximo"; 
            KeySeparator   = ".";
            Grouping       = PowerwaterEntities.Maximo; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Powerwater Maximo Details", group =>
            {
                Location = group.Add(new VocabularyKey("Location", "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey("Type", "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlAcc = group.Add(new VocabularyKey("ControlAcc", "Control Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GlAccount = group.Add(new VocabularyKey("GlAccount", "Gl Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchVarAcc = group.Add(new VocabularyKey("PurchVarAcc", "Purch Var Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVarAcc = group.Add(new VocabularyKey("InvoiceVarAcc", "Invoice Var Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurVarAcc = group.Add(new VocabularyKey("CurVarAcc", "Cur Var Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShrinkAgeAcc = group.Add(new VocabularyKey("ShrinkAgeAcc", "Shrink Age Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvCostAdjAcc = group.Add(new VocabularyKey("InvCostAdjAcc", "Inv Cost Adj Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptVarAcc = group.Add(new VocabularyKey("ReceiptVarAcc", "Receipt Var Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeBy = group.Add(new VocabularyKey("ChangeBy", "Change By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeDate = group.Add(new VocabularyKey("ChangeDate", "Change Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Disabled = group.Add(new VocabularyKey("Disabled", "Disabled", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldControlAcc = group.Add(new VocabularyKey("OldControlAcc", "Old Control Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldShrinkAgeAcc = group.Add(new VocabularyKey("OldShrinkAgeAcc", "Old Shrink Age Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldInvCostAdjacc = group.Add(new VocabularyKey("OldInvCostAdjacc", "Old Inv Cost Adjacc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassStructureId = group.Add(new VocabularyKey("ClassStructureId", "Class Structure Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisParam1 = group.Add(new VocabularyKey("GisParam1", "Gis Param 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisParam2 = group.Add(new VocabularyKey("GisParam2", "Gis Param 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisParam3 = group.Add(new VocabularyKey("GisParam3", "Gis Param 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceSysId = group.Add(new VocabularyKey("SourceSysId", "Source Sys Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerSysId = group.Add(new VocabularyKey("OwnerSysId", "Owner Sys Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalRefId = group.Add(new VocabularyKey("ExternalRefId", "External Ref Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SenderSysId = group.Add(new VocabularyKey("SenderSysId", "Sender Sys Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteId = group.Add(new VocabularyKey("SiteId", "Site Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrgId = group.Add(new VocabularyKey("OrgId", "Org Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntLabRec = group.Add(new VocabularyKey("IntLabRec", "Int Lab Rec", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey("IsDefault", "Is Default?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToAddressCode = group.Add(new VocabularyKey("ShipToAddressCode", "Ship To Address Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToLaborCode = group.Add(new VocabularyKey("ShipToLaborCode", "Ship To Labor Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillToAddressCode = group.Add(new VocabularyKey("BillToAddressCode", "Bill To Address Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillToLaborCode = group.Add(new VocabularyKey("BillToLaborCode", "Bill To Labor Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey("Status", "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressCode = group.Add(new VocabularyKey("ServiceAddressCode", "Service Address Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationSid = group.Add(new VocabularyKey("LocationSid", "Location Sid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInPopr = group.Add(new VocabularyKey("UseInPopr", "Use In Popr", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToolControlAcc = group.Add(new VocabularyKey("ToolControlAcc", "Tool Control Acc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LangCode = group.Add(new VocabularyKey("LangCode", "Lang Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hasld = group.Add(new VocabularyKey("Hasld", "Hasld", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoWogen = group.Add(new VocabularyKey("AutoWogen", "Auto Wogen", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusDate = group.Add(new VocabularyKey("StatusDate", "Status Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFacility = group.Add(new VocabularyKey("IsFacility", "Is Facility?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Facility = group.Add(new VocabularyKey("Facility", "Facility", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Area = group.Add(new VocabularyKey("Area", "Area", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Alias = group.Add(new VocabularyKey("Alias", "Alias", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstalledDate = group.Add(new VocabularyKey("InstalledDate", "Installed Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstalledBy = group.Add(new VocabularyKey("InstalledBy", "Installed By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey("Owner", "Owner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessUnit = group.Add(new VocabularyKey("BusinessUnit", "Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Community = group.Add(new VocabularyKey("Community", "Community", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Department = group.Add(new VocabularyKey("Department", "Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Service = group.Add(new VocabularyKey("Service", "Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussFeatureClass = group.Add(new VocabularyKey("PlussFeatureClass", "Pluss Feature Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussIsGis = group.Add(new VocabularyKey("PlussIsGis", "Pluss Is Gis", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowStamp = group.Add(new VocabularyKey("RowStamp", "Row Stamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussAddressCode = group.Add(new VocabularyKey("PlussAddressCode", "Pluss Address Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussDescription = group.Add(new VocabularyKey("PlussDescription", "Pluss Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStaddrNumber = group.Add(new VocabularyKey("PlussStaddrNumber", "Pluss Staddr Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStaddrDirPrfx = group.Add(new VocabularyKey("PlussStaddrDirPrfx", "Pluss Staddr Dir Prfx", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStaddrStreet = group.Add(new VocabularyKey("PlussStaddrStreet", "Pluss Staddr Street", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStaddrSttype = group.Add(new VocabularyKey("PlussStaddrSttype", "Pluss Staddr Sttype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStaddrDirSfx = group.Add(new VocabularyKey("PlussStaddrDirSfx", "Pluss Staddr Dir Sfx", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStaddrUnitNum = group.Add(new VocabularyKey("PlussStaddrUnitNum", "Pluss Staddr Unit Num", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStreetAddress = group.Add(new VocabularyKey("PlussStreetAddress", "Pluss Street Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussAddressLine2 = group.Add(new VocabularyKey("PlussAddressLine2", "Pluss Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussAddressLine3 = group.Add(new VocabularyKey("PlussAddressLine3", "Pluss Address Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussCity = group.Add(new VocabularyKey("PlussCity", "Pluss City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussRegionDistrict = group.Add(new VocabularyKey("PlussRegionDistrict", "Pluss Region District", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussCounty = group.Add(new VocabularyKey("PlussCounty", "Pluss County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussStateProvince = group.Add(new VocabularyKey("PlussStateProvince", "Pluss State Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussPostalCode = group.Add(new VocabularyKey("PlussPostalCode", "Pluss Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussCountry = group.Add(new VocabularyKey("PlussCountry", "Pluss Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussGeocode = group.Add(new VocabularyKey("PlussGeocode", "Pluss Geocode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussTimezone = group.Add(new VocabularyKey("PlussTimezone", "Pluss Timezone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussLatitude = group.Add(new VocabularyKey("PlussLatitude", "Pluss Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussLongitude = group.Add(new VocabularyKey("PlussLongitude", "Pluss Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussReferencePoint = group.Add(new VocabularyKey("PlussReferencePoint", "Pluss Reference Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlussDirections = group.Add(new VocabularyKey("PlussDirections", "Pluss Directions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutoIssueParts = group.Add(new VocabularyKey("IsAutoIssueParts", "Is Auto Issue Parts?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoIssueLeadTime = group.Add(new VocabularyKey("AutoIssueLeadTime", "Auto Issue Lead Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoIssueStatus = group.Add(new VocabularyKey("AutoIssueStatus", "Auto Issue Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVehicle = group.Add(new VocabularyKey("IsVehicle", "Is Vehicle?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Vendor = group.Add(new VocabularyKey("Vendor", "Vendor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PluscDueDate = group.Add(new VocabularyKey("PluscDueDate", "Plusc Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PluscLoop = group.Add(new VocabularyKey("PluscLoop", "Plusc Loop", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PluscPmextDate = group.Add(new VocabularyKey("PluscPmextDate", "Plusc Pmext Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRecloser = group.Add(new VocabularyKey("IsRecloser", "Is Recloser?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFeeder = group.Add(new VocabularyKey("IsFeeder", "Is Feeder?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSubStation = group.Add(new VocabularyKey("IsSubStation", "Is Sub Station?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeederId = group.Add(new VocabularyKey("FeederId", "Feeder Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubStationId = group.Add(new VocabularyKey("SubStationId", "Sub Station Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecloserId = group.Add(new VocabularyKey("RecloserId", "Recloser Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                System = group.Add(new VocabularyKey("System", "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemType = group.Add(new VocabularyKey("SystemType", "System Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Maintainer = group.Add(new VocabularyKey("Maintainer", "Maintainer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScadaId = group.Add(new VocabularyKey("ScadaId", "Scada Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FisLegacyId = group.Add(new VocabularyKey("FisLegacyId", "Fis Legacy Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WimsLegacyId = group.Add(new VocabularyKey("WimsLegacyId", "Wims Legacy Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfRouteToPerson = group.Add(new VocabularyKey("WfRouteToPerson", "Wf Route To Person", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfRouteToPersonGroup = group.Add(new VocabularyKey("WfRouteToPersonGroup", "Wf Route To Person Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfInteractive = group.Add(new VocabularyKey("WfInteractive", "Wf Interactive", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldWfRouteToPerson = group.Add(new VocabularyKey("OldWfRouteToPerson", "Old Wf Route To Person", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OldWfRouteToPersonGroup = group.Add(new VocabularyKey("OldWfRouteToPersonGroup", "Old Wf Route To Person Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunityEnglishName = group.Add(new VocabularyKey("CommunityEnglishName", "Community English Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunityName = group.Add(new VocabularyKey("CommunityName", "Community Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunityTradition = group.Add(new VocabularyKey("CommunityTradition", "Community Tradition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryCondition = group.Add(new VocabularyKey("EntryCondition", "Entry Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Erp = group.Add(new VocabularyKey("Erp", "Erp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecificationDescription = group.Add(new VocabularyKey("SpecificationDescription", "Specification Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetBusinessUnit = group.Add(new VocabularyKey("AssetBusinessUnit", "Asset Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetDepartment = group.Add(new VocabularyKey("AssetDepartment", "Asset Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetGroup = group.Add(new VocabularyKey("AssetGroup", "Asset Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetOwner = group.Add(new VocabularyKey("AssetOwner", "Asset Owner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchmentMajor = group.Add(new VocabularyKey("CatchmentMajor", "Catchment Major", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchmentMinor = group.Add(new VocabularyKey("CatchmentMinor", "Catchment Minor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchmentZone = group.Add(new VocabularyKey("CatchmentZone", "Catchment Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionDate = group.Add(new VocabularyKey("CommissionDate", "Commission Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunityAcronym = group.Add(new VocabularyKey("CommunityAcronym", "Community Acronym", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunityAlias = group.Add(new VocabularyKey("CommunityAlias", "Community Alias", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunityId = group.Add(new VocabularyKey("CommunityId", "Community Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriticalCustomer = group.Add(new VocabularyKey("CriticalCustomer", "Critical Customer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecommissionDate = group.Add(new VocabularyKey("DecommissionDate", "Decommission Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisGlobalId = group.Add(new VocabularyKey("GisGlobalId", "Gis Global Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocArea = group.Add(new VocabularyKey("LocArea", "Loc Area", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocCommunity = group.Add(new VocabularyKey("LocCommunity", "Loc Community", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocRegion = group.Add(new VocabularyKey("LocRegion", "Loc Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaintainerBusinessUnit = group.Add(new VocabularyKey("MaintainerBusinessUnit", "Maintainer Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaintainerDepartment = group.Add(new VocabularyKey("MaintainerDepartment", "Maintainer Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaintainerGroup = group.Add(new VocabularyKey("MaintainerGroup", "Maintainer Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PendingEdit = group.Add(new VocabularyKey("PendingEdit", "Pending Edit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaterSystem = group.Add(new VocabularyKey("WaterSystem", "Water System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfEscalationDays = group.Add(new VocabularyKey("WfEscalationDays", "Wf Escalation Days", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfMemoList = group.Add(new VocabularyKey("WfMemoList", "Wf Memo List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WfStatus = group.Add(new VocabularyKey("WfStatus", "Wf Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationCode = group.Add(new VocabularyKey("LocationCode", "Location Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FisLegacyTbName = group.Add(new VocabularyKey("FisLegacyTbName", "Fis Legacy Tb Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Locality = group.Add(new VocabularyKey("Locality", "Locality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rdspp = group.Add(new VocabularyKey("Rdspp", "Rdspp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubUrb = group.Add(new VocabularyKey("SubUrb", "Sub Urb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisErrorMessage = group.Add(new VocabularyKey("GisErrorMessage", "Gis Error Message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisProcessedDate = group.Add(new VocabularyKey("GisProcessedDate", "Gis Processed Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DogCode = group.Add(new VocabularyKey("DogCode", "Dog Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriticalCode = group.Add(new VocabularyKey("CriticalCode", "Critical Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriticalFlag = group.Add(new VocabularyKey("CriticalFlag", "Critical Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerCode = group.Add(new VocabularyKey("CustomerCode", "Customer Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumerCode = group.Add(new VocabularyKey("ConsumerCode", "Consumer Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceEnduse = group.Add(new VocabularyKey("ServiceEnduse", "Service Enduse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsThreateningCustomer = group.Add(new VocabularyKey("IsThreateningCustomer", "Is Threatening Customer?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisconnectDate = group.Add(new VocabularyKey("DisconnectDate", "Disconnect Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeterLocationCode = group.Add(new VocabularyKey("MeterLocationCode", "Meter Location Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeterRemarks = group.Add(new VocabularyKey("MeterRemarks", "Meter Remarks", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenantCode = group.Add(new VocabularyKey("TenantCode", "Tenant Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisServiceName = group.Add(new VocabularyKey("GisServiceName", "Gis Service Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultipleAssets = group.Add(new VocabularyKey("MultipleAssets", "Multiple Assets", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocClassificationId = group.Add(new VocabularyKey("LocClassificationId", "Loc Classification Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClasssHortCode = group.Add(new VocabularyKey("ClasssHortCode", "Classs Hort Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPvMeter= group.Add(new VocabularyKey("IsPvMeter", "Is Pv Meter?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyNumber = group.Add(new VocabularyKey("KeyNumber", "Key Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeterPostion = group.Add(new VocabularyKey("MeterPostion", "Meter Postion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrePaymentMeter = group.Add(new VocabularyKey("PrePaymentMeter", "Pre-Payment Meter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Restrictorapplied = group.Add(new VocabularyKey("Restrictorapplied", "Restrictorapplied", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailerCode = group.Add(new VocabularyKey("RetailerCode", "Retailer Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UndergroundNetwork = group.Add(new VocabularyKey("UndergroundNetwork", "Underground Network", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerFeeder = group.Add(new VocabularyKey("CustomerFeeder", "Customer Feeder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeederCategory = group.Add(new VocabularyKey("FeederCategory", "Feeder Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallCount = group.Add(new VocabularyKey("InstallCount", "Install Count", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LengthInMetres = group.Add(new VocabularyKey("LengthInMetres", "Length In Metres", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NominalkVaLoad = group.Add(new VocabularyKey("NominalkVaLoad", "Nominalk Va Load", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voltage = group.Add(new VocabularyKey("Voltage", "Voltage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreaInSquareMetres = group.Add(new VocabularyKey("AreaInSquareMetres", "Area In Square Metres", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisSubType = group.Add(new VocabularyKey("GisSubType", "Gis Sub Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PressureZoneId = group.Add(new VocabularyKey("PressureZoneId", "Pressure Zone Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisLocTemp = group.Add(new VocabularyKey("GisLocTemp", "Gis Loc Temp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTestLocation = group.Add(new VocabularyKey("IsTestLocation", "Is Test Location?", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecomStore = group.Add(new VocabularyKey("DecomStore", "Decom Store", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GisPreventParentUpdate = group.Add(new VocabularyKey("GisPreventParentUpdate", "Gis Prevent Parent Update", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualFeederId = group.Add(new VocabularyKey("ManualFeederId", "Manual Feeder Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AerFeeder = group.Add(new VocabularyKey("AerFeeder", "Aer Feeder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationSyncId = group.Add(new VocabularyKey("LocationSyncId", "Location Sync Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey ControlAcc { get; private set; }
        public VocabularyKey GlAccount { get; private set; }
        public VocabularyKey PurchVarAcc { get; private set; }
        public VocabularyKey InvoiceVarAcc { get; private set; }
        public VocabularyKey CurVarAcc { get; private set; }
        public VocabularyKey ShrinkAgeAcc { get; private set; }
        public VocabularyKey InvCostAdjAcc { get; private set; }
        public VocabularyKey ReceiptVarAcc { get; private set; }
        public VocabularyKey ChangeBy { get; private set; }
        public VocabularyKey ChangeDate { get; private set; }
        public VocabularyKey Disabled { get; private set; }
        public VocabularyKey OldControlAcc { get; private set; }
        public VocabularyKey OldShrinkAgeAcc { get; private set; }
        public VocabularyKey OldInvCostAdjacc { get; private set; }
        public VocabularyKey ClassStructureId { get; private set; }
        public VocabularyKey GisParam1 { get; private set; }
        public VocabularyKey GisParam2 { get; private set; }
        public VocabularyKey GisParam3 { get; private set; }
        public VocabularyKey SourceSysId { get; private set; }
        public VocabularyKey OwnerSysId { get; private set; }
        public VocabularyKey ExternalRefId { get; private set; }
        public VocabularyKey SenderSysId { get; private set; }
        public VocabularyKey SiteId { get; private set; }
        public VocabularyKey OrgId { get; private set; }
        public VocabularyKey IntLabRec { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey ShipToAddressCode { get; private set; }
        public VocabularyKey ShipToLaborCode { get; private set; }
        public VocabularyKey BillToAddressCode { get; private set; }
        public VocabularyKey BillToLaborCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ServiceAddressCode { get; private set; }
        public VocabularyKey LocationSid { get; private set; }
        public VocabularyKey UseInPopr { get; private set; }
        public VocabularyKey ToolControlAcc { get; private set; }
        public VocabularyKey LangCode { get; private set; }
        public VocabularyKey Hasld { get; private set; }
        public VocabularyKey AutoWogen { get; private set; }
        public VocabularyKey StatusDate { get; private set; }
        public VocabularyKey IsFacility { get; private set; }
        public VocabularyKey Facility { get; private set; }
        public VocabularyKey Area { get; private set; }
        public VocabularyKey Alias { get; private set; }
        public VocabularyKey InstalledDate { get; private set; }
        public VocabularyKey InstalledBy { get; private set; }
        public VocabularyKey Owner { get; private set; }
        public VocabularyKey BusinessUnit { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Service { get; private set; }
        public VocabularyKey PlussFeatureClass { get; private set; }
        public VocabularyKey PlussIsGis { get; private set; }
        public VocabularyKey RowStamp { get; private set; }
        public VocabularyKey PlussAddressCode { get; private set; }
        public VocabularyKey PlussDescription { get; private set; }
        public VocabularyKey PlussStaddrNumber { get; private set; }
        public VocabularyKey PlussStaddrDirPrfx { get; private set; }
        public VocabularyKey PlussStaddrStreet { get; private set; }
        public VocabularyKey PlussStaddrSttype { get; private set; }
        public VocabularyKey PlussStaddrDirSfx { get; private set; }
        public VocabularyKey PlussStaddrUnitNum { get; private set; }
        public VocabularyKey PlussStreetAddress { get; private set; }
        public VocabularyKey PlussAddressLine2 { get; private set; }
        public VocabularyKey PlussAddressLine3 { get; private set; }
        public VocabularyKey PlussCity { get; private set; }
        public VocabularyKey PlussRegionDistrict { get; private set; }
        public VocabularyKey PlussCounty { get; private set; }
        public VocabularyKey PlussStateProvince { get; private set; }
        public VocabularyKey PlussPostalCode { get; private set; }
        public VocabularyKey PlussCountry { get; private set; }
        public VocabularyKey PlussGeocode { get; private set; }
        public VocabularyKey PlussTimezone { get; private set; }
        public VocabularyKey PlussLatitude { get; private set; }
        public VocabularyKey PlussLongitude { get; private set; }
        public VocabularyKey PlussReferencePoint { get; private set; }
        public VocabularyKey PlussDirections { get; private set; }
        public VocabularyKey IsAutoIssueParts { get; private set; }
        public VocabularyKey AutoIssueLeadTime { get; private set; }
        public VocabularyKey AutoIssueStatus { get; private set; }
        public VocabularyKey IsVehicle { get; private set; }
        public VocabularyKey Vendor { get; private set; }
        public VocabularyKey PluscDueDate { get; private set; }
        public VocabularyKey PluscLoop { get; private set; }
        public VocabularyKey PluscPmextDate { get; private set; }
        public VocabularyKey IsRecloser { get; private set; }
        public VocabularyKey IsFeeder { get; private set; }
        public VocabularyKey IsSubStation { get; private set; }
        public VocabularyKey FeederId { get; private set; }
        public VocabularyKey SubStationId { get; private set; }
        public VocabularyKey RecloserId { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey SystemType { get; private set; }
        public VocabularyKey Maintainer { get; private set; }
        public VocabularyKey ScadaId { get; private set; }
        public VocabularyKey FisLegacyId { get; private set; }
        public VocabularyKey WimsLegacyId { get; private set; }
        public VocabularyKey WfRouteToPerson { get; private set; }
        public VocabularyKey WfRouteToPersonGroup { get; private set; }
        public VocabularyKey WfInteractive { get; private set; }
        public VocabularyKey OldWfRouteToPerson { get; private set; }
        public VocabularyKey OldWfRouteToPersonGroup { get; private set; }
        public VocabularyKey CommunityEnglishName { get; private set; }
        public VocabularyKey CommunityName { get; private set; }
        public VocabularyKey CommunityTradition { get; private set; }
        public VocabularyKey EntryCondition { get; private set; }
        public VocabularyKey Erp { get; private set; }
        public VocabularyKey SpecificationDescription { get; private set; }
        public VocabularyKey AssetBusinessUnit { get; private set; }
        public VocabularyKey AssetDepartment { get; private set; }
        public VocabularyKey AssetGroup { get; private set; }
        public VocabularyKey AssetOwner { get; private set; }
        public VocabularyKey CatchmentMajor { get; private set; }
        public VocabularyKey CatchmentMinor { get; private set; }
        public VocabularyKey CatchmentZone { get; private set; }
        public VocabularyKey CommissionDate { get; private set; }
        public VocabularyKey CommunityAcronym { get; private set; }
        public VocabularyKey CommunityAlias { get; private set; }
        public VocabularyKey CommunityId { get; private set; }
        public VocabularyKey CriticalCustomer { get; private set; }
        public VocabularyKey DecommissionDate { get; private set; }
        public VocabularyKey GisGlobalId { get; private set; }
        public VocabularyKey LocArea { get; private set; }
        public VocabularyKey LocCommunity { get; private set; }
        public VocabularyKey LocRegion { get; private set; }
        public VocabularyKey MaintainerBusinessUnit { get; private set; }
        public VocabularyKey MaintainerDepartment { get; private set; }
        public VocabularyKey MaintainerGroup { get; private set; }
        public VocabularyKey PendingEdit { get; private set; }
        public VocabularyKey WaterSystem { get; private set; }
        public VocabularyKey WfEscalationDays { get; private set; }
        public VocabularyKey WfMemoList { get; private set; }
        public VocabularyKey WfStatus { get; private set; }
        public VocabularyKey LocationCode { get; private set; }
        public VocabularyKey FisLegacyTbName { get; private set; }
        public VocabularyKey Locality { get; private set; }
        public VocabularyKey Rdspp { get; private set; }
        public VocabularyKey SubUrb { get; private set; }
        public VocabularyKey GisErrorMessage { get; private set; }
        public VocabularyKey GisProcessedDate { get; private set; }
        public VocabularyKey DogCode { get; private set; }
        public VocabularyKey CriticalCode { get; private set; }
        public VocabularyKey CriticalFlag { get; private set; }
        public VocabularyKey CustomerCode { get; private set; }
        public VocabularyKey ConsumerCode { get; private set; }
        public VocabularyKey ServiceEnduse { get; private set; }
        public VocabularyKey IsThreateningCustomer { get; private set; }
        public VocabularyKey DisconnectDate { get; private set; }
        public VocabularyKey MeterLocationCode { get; private set; }
        public VocabularyKey MeterRemarks { get; private set; }
        public VocabularyKey TenantCode { get; private set; }
        public VocabularyKey GisServiceName { get; private set; }
        public VocabularyKey MultipleAssets { get; private set; }
        public VocabularyKey LocClassificationId { get; private set; }
        public VocabularyKey ClasssHortCode { get; private set; }
        public VocabularyKey IsPvMeter { get; private set; }
        public VocabularyKey KeyNumber { get; private set; }
        public VocabularyKey MeterPostion { get; private set; }
        public VocabularyKey PrePaymentMeter { get; private set; }
        public VocabularyKey Restrictorapplied { get; private set; }
        public VocabularyKey RetailerCode { get; private set; }
        public VocabularyKey UndergroundNetwork { get; private set; }
        public VocabularyKey CustomerFeeder { get; private set; }
        public VocabularyKey FeederCategory { get; private set; }
        public VocabularyKey InstallCount { get; private set; }
        public VocabularyKey LengthInMetres { get; private set; }
        public VocabularyKey NominalkVaLoad { get; private set; }
        public VocabularyKey Voltage { get; private set; }
        public VocabularyKey AreaInSquareMetres { get; private set; }
        public VocabularyKey GisSubType { get; private set; }
        public VocabularyKey PressureZoneId { get; private set; }
        public VocabularyKey GisLocTemp { get; private set; }
        public VocabularyKey IsTestLocation { get; private set; }
        public VocabularyKey DecomStore { get; private set; }
        public VocabularyKey GisPreventParentUpdate { get; private set; }
        public VocabularyKey ManualFeederId { get; private set; }
        public VocabularyKey AerFeeder { get; private set; }
        public VocabularyKey LocationSyncId { get; private set; }

}
}
