using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Constants;

namespace CluedIn.Crawling.Powerwater.Vocabularies
{
    public class  GenProdVocabulary : SimpleVocabulary
    {
        public  GenProdVocabulary()
        {
            VocabularyName = "Powerwater GenProd"; 
            KeyPrefix      = "powerwater.genprod"; 
            KeySeparator   = ".";
            Grouping       = PowerwaterEntities.GenProd; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Powerwater GenProd Details", group =>
            {
                Install = group.Add(new VocabularyKey("Install", "Install", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Meter = group.Add(new VocabularyKey("Meter", "Meter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnbillMeter = group.Add(new VocabularyKey("UnbillMeter", "Unbill Meter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrevMeter = group.Add(new VocabularyKey("PrevMeter", "Prev Meter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasInstall = group.Add(new VocabularyKey("MasInstall", "Mas Install", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare5 = group.Add(new VocabularyKey("Spare5", "Spare 5", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KvaRating = group.Add(new VocabularyKey("KvaRating", "Kva Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare7 = group.Add(new VocabularyKey("Spare7", "Spare 7", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fcharge = group.Add(new VocabularyKey("Fcharge", "Fcharge", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fcdesc = group.Add(new VocabularyKey("Fcdesc", "Fcdesc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FchargeMultp = group.Add(new VocabularyKey("FchargeMultp", "Fcharge Multp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FcstDate = group.Add(new VocabularyKey("FcstDate", "Fcst Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FcenDate = group.Add(new VocabularyKey("FcenDate", "Fcen Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare13 = group.Add(new VocabularyKey("Spare13", "Spare 13", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare14 = group.Add(new VocabularyKey("Spare14", "Spare 14", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare15 = group.Add(new VocabularyKey("Spare15", "Spare 15", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TouenDate = group.Add(new VocabularyKey("TouenDate", "Touen Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToustDate = group.Add(new VocabularyKey("ToustDate", "Toust Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare18 = group.Add(new VocabularyKey("Spare18", "Spare 18", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CpIdent = group.Add(new VocabularyKey("CpIdent", "Cp Ident", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CtNumber = group.Add(new VocabularyKey("CtNumber", "Ct Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubStation = group.Add(new VocabularyKey("SubStation", "Sub-Station", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Shutdown = group.Add(new VocabularyKey("Shutdown", "Shutdown", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TouFlag = group.Add(new VocabularyKey("TouFlag", "Tou Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TouCharge = group.Add(new VocabularyKey("TouCharge", "Tou Charge", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TouDesc = group.Add(new VocabularyKey("TouDesc", "Tou Desc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MrFlag = group.Add(new VocabularyKey("MrFlag", "Mr Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MrFlagRm = group.Add(new VocabularyKey("MrFlagRm", "Mr Flag Rm", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostEdit = group.Add(new VocabularyKey("PostEdit", "Post Edit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NzedCode = group.Add(new VocabularyKey("NzedCode", "Nzed Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropNo = group.Add(new VocabularyKey("PropNo", "Prop No", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Consumer = group.Add(new VocabularyKey("Consumer", "Consumer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MrNotes = group.Add(new VocabularyKey("MrNotes", "Mr Notes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pissue = group.Add(new VocabularyKey("Pissue", "Pissue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppCodes = group.Add(new VocabularyKey("AppCodes", "App Codes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppQty = group.Add(new VocabularyKey("AppQty", "App Qty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppKw = group.Add(new VocabularyKey("AppKw", "App Kw", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppControl = group.Add(new VocabularyKey("AppControl", "App Control", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey("Location", "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Wissue = group.Add(new VocabularyKey("Wissue", "Wissue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteNo = group.Add(new VocabularyKey("SiteNo", "Site No", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelayNo = group.Add(new VocabularyKey("RelayNo", "Relay No", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrFreeform = group.Add(new VocabularyKey("AddrFreeform", "Addr Freeform", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrUnit = group.Add(new VocabularyKey("AddrUnit", "Addr Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrHouse = group.Add(new VocabularyKey("AddrHouse", "Addr House", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrStreet = group.Add(new VocabularyKey("AddrStreet", "Addr Street", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrPoBox = group.Add(new VocabularyKey("AddrPoBox", "Addr Po-Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrSubUrb = group.Add(new VocabularyKey("AddrSubUrb", "Addr Sub-Urb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrTownCity = group.Add(new VocabularyKey("AddrTownCity", "Addr Town City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrPostCode = group.Add(new VocabularyKey("AddrPostCode", "Addr Post Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrUnitType = group.Add(new VocabularyKey("AddrUnitType", "Addr Unit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrBuilding = group.Add(new VocabularyKey("AddrBuilding", "Addr Building", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrState = group.Add(new VocabularyKey("AddrState", "Addr State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrFloor = group.Add(new VocabularyKey("AddrFloor", "Addr Floor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrCountry = group.Add(new VocabularyKey("AddrCountry", "Addr Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrStrType = group.Add(new VocabularyKey("AddrStrType", "Addr Str Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrDirection = group.Add(new VocabularyKey("AddrDirection", "Addr Direction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrCounty = group.Add(new VocabularyKey("AddrCounty", "Addr County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrSubdivisn = group.Add(new VocabularyKey("AddrSubdivisn", "Addr Subdivisn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddrPostCode2 = group.Add(new VocabularyKey("AddrPostCode2", "Addr Post Code 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare43 = group.Add(new VocabularyKey("Spare43", "Spare 43", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillPer = group.Add(new VocabularyKey("BillPer", "Bill Per", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillSeq = group.Add(new VocabularyKey("BillSeq", "Bill Seq", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextDate = group.Add(new VocabularyKey("NextDate", "Next Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeterLoc = group.Add(new VocabularyKey("MeterLoc", "Meter Loc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastDate = group.Add(new VocabularyKey("LastDate", "Last Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                District = group.Add(new VocabularyKey("District", "District", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrevNoDays = group.Add(new VocabularyKey("PrevNoDays", "Prev No Days", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LreadDate = group.Add(new VocabularyKey("LreadDate", "Lread Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GasGate = group.Add(new VocabularyKey("GasGate", "Gas Gate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NstType = group.Add(new VocabularyKey("NstType", "Nst Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LbillType = group.Add(new VocabularyKey("LbillType", "Lbill Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare55 = group.Add(new VocabularyKey("Spare55", "Spare 55", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstSuppress = group.Add(new VocabularyKey("EstSuppress", "Est Suppress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstOrideDate = group.Add(new VocabularyKey("EstOrideDate", "Est Oride Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstOrideType = group.Add(new VocabularyKey("EstOrideType", "Est Oride Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare59 = group.Add(new VocabularyKey("Spare59", "Spare 59", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnAcct = group.Add(new VocabularyKey("OwnAcct", "Own Acct", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrFreeForm = group.Add(new VocabularyKey("LegalPaddrFreeForm", "Legal Paddr Free Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrUnit = group.Add(new VocabularyKey("LegalPaddrUnit", "Legal Paddr Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrHouse = group.Add(new VocabularyKey("LegalPaddrHouse", "Legal Paddr House", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrStreet = group.Add(new VocabularyKey("LegalPaddrStreet", "Legal Paddr Street", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrPoBox = group.Add(new VocabularyKey("LegalPaddrPoBox", "Legal Paddr Po-Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrSubUrb = group.Add(new VocabularyKey("LegalPaddrSubUrb", "Legal Paddr Sub-Urb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrTownCity = group.Add(new VocabularyKey("LegalPaddrTownCity", "Legal Paddr Town City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrPostCode = group.Add(new VocabularyKey("LegalPaddrPostCode", "Legal Paddr Post Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrUnitType = group.Add(new VocabularyKey("LegalPaddrUnitType", "Legal Paddr Unit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrBuilding = group.Add(new VocabularyKey("LegalPaddrBuilding", "Legal Paddr Building", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrState = group.Add(new VocabularyKey("LegalPaddrState", "Legal Paddr State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrFloor = group.Add(new VocabularyKey("LegalPaddrFloor", "Legal Paddr Floor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrCountry = group.Add(new VocabularyKey("LegalPaddrCountry", "Legal Paddr Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrStrtype = group.Add(new VocabularyKey("LegalPaddrStrtype", "Legal Paddr Strtype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrDirection = group.Add(new VocabularyKey("LegalPaddrDirection", "Legal Paddr Direction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrCounty = group.Add(new VocabularyKey("LegalPaddrCounty", "Legal Paddr County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrSubdivisn = group.Add(new VocabularyKey("LegalPaddrSubdivisn", "Legal Paddr Subdivisn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalPaddrPostCode2 = group.Add(new VocabularyKey("LegalPaddrPostCode2", "Legal Paddr Post Code 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChgClass = group.Add(new VocabularyKey("ChgClass", "Chg Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare63 = group.Add(new VocabularyKey("Spare63", "Spare 63", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare64 = group.Add(new VocabularyKey("Spare64", "Spare 64", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare65 = group.Add(new VocabularyKey("Spare65", "Spare 65", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare66 = group.Add(new VocabularyKey("Spare66", "Spare 66", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare67 = group.Add(new VocabularyKey("Spare67", "Spare 67", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AltEnergyCo = group.Add(new VocabularyKey("AltEnergyCo", "Alt Energy Co", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AltEnergyDate = group.Add(new VocabularyKey("AltEnergyDate", "Alt Energy Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AltEnergyCons = group.Add(new VocabularyKey("AltEnergyCons", "Alt Energy Cons", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AltLineCo = group.Add(new VocabularyKey("AltLineCo", "Alt Line Co", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AltLineDate = group.Add(new VocabularyKey("AltLineDate", "Alt Line Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeshBlock = group.Add(new VocabularyKey("MeshBlock", "Mesh Block", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FutureCons = group.Add(new VocabularyKey("FutureCons", "Future Cons", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyNumber = group.Add(new VocabularyKey("KeyNumber", "Key Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectDate = group.Add(new VocabularyKey("ConnectDate", "Connect Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisconnectType = group.Add(new VocabularyKey("DisconnectType", "Disconnect Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Disconnect = group.Add(new VocabularyKey("Disconnect", "Disconnect", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisconnectReason = group.Add(new VocabularyKey("DisconnectReason", "Disconnect Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconnectAuth = group.Add(new VocabularyKey("ReconnectAuth", "Reconnect Auth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconnectDate = group.Add(new VocabularyKey("ReconnectDate", "Reconnect Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HvFlag = group.Add(new VocabularyKey("HvFlag", "Hv Flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NominatedKva = group.Add(new VocabularyKey("NominatedKva", "Nominated Kva", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MetNetwork = group.Add(new VocabularyKey("MetNetwork", "Met Network", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare85 = group.Add(new VocabularyKey("Spare85", "Spare 85", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlKva = group.Add(new VocabularyKey("ControlKva", "Control Kva", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisconnectLoc = group.Add(new VocabularyKey("DisconnectLoc", "Disconnect Loc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Altitude = group.Add(new VocabularyKey("Altitude", "Altitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineFactor = group.Add(new VocabularyKey("LineFactor", "Line Factor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NwCostFchg = group.Add(new VocabularyKey("NwCostFchg", "Nw Cost Fchg", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NwCostFchgMult = group.Add(new VocabularyKey("NwCostFchgMult", "Nw Cost Fchg Mult", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AltEnergyEndDate = group.Add(new VocabularyKey("AltEnergyEndDate", "Alt Energy End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UtilityType = group.Add(new VocabularyKey("UtilityType", "Utility Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TieredInx = group.Add(new VocabularyKey("TieredInx", "Tiered Inx", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare95 = group.Add(new VocabularyKey("Spare95", "Spare 95", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare96 = group.Add(new VocabularyKey("Spare96", "Spare 96", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare97 = group.Add(new VocabularyKey("Spare97", "Spare 97", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare98 = group.Add(new VocabularyKey("Spare98", "Spare 98", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare99 = group.Add(new VocabularyKey("Spare99", "Spare 99", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Spare100 = group.Add(new VocabularyKey("Spare100", "Spare 100", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullAddress = group.Add(new VocabularyKey("FullAddress", "Full Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.

            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
            AddMapping(AddrHouse, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressStreetNumber);
            AddMapping(AddrStreet, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
            AddMapping(AddrTownCity, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressCity);
        }
        public VocabularyKey Install { get; private set; }
        public VocabularyKey Meter { get; private set; }
        public VocabularyKey UnbillMeter { get; private set; }
        public VocabularyKey PrevMeter { get; private set; }
        public VocabularyKey MasInstall { get; private set; }
        public VocabularyKey Spare5 { get; private set; }
        public VocabularyKey KvaRating { get; private set; }
        public VocabularyKey Spare7 { get; private set; }
        public VocabularyKey Fcharge { get; private set; }
        public VocabularyKey Fcdesc { get; private set; }
        public VocabularyKey FchargeMultp { get; private set; }
        public VocabularyKey FcstDate { get; private set; }
        public VocabularyKey FcenDate { get; private set; }
        public VocabularyKey Spare13 { get; private set; }
        public VocabularyKey Spare14 { get; private set; }
        public VocabularyKey Spare15 { get; private set; }
        public VocabularyKey TouenDate { get; private set; }
        public VocabularyKey ToustDate { get; private set; }
        public VocabularyKey Spare18 { get; private set; }
        public VocabularyKey CpIdent { get; private set; }
        public VocabularyKey CtNumber { get; private set; }
        public VocabularyKey SubStation { get; private set; }
        public VocabularyKey Shutdown { get; private set; }
        public VocabularyKey TouFlag { get; private set; }
        public VocabularyKey TouCharge { get; private set; }
        public VocabularyKey TouDesc { get; private set; }
        public VocabularyKey MrFlag { get; private set; }
        public VocabularyKey MrFlagRm { get; private set; }
        public VocabularyKey PostEdit { get; private set; }
        public VocabularyKey NzedCode { get; private set; }
        public VocabularyKey PropNo { get; private set; }
        public VocabularyKey Consumer { get; private set; }
        public VocabularyKey MrNotes { get; private set; }
        public VocabularyKey Pissue { get; private set; }
        public VocabularyKey AppCodes { get; private set; }
        public VocabularyKey AppQty { get; private set; }
        public VocabularyKey AppKw { get; private set; }
        public VocabularyKey AppControl { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Wissue { get; private set; }
        public VocabularyKey SiteNo { get; private set; }
        public VocabularyKey RelayNo { get; private set; }
        public VocabularyKey AddrFreeform { get; private set; }
        public VocabularyKey AddrUnit { get; private set; }
        public VocabularyKey AddrHouse { get; private set; }
        public VocabularyKey AddrStreet { get; private set; }
        public VocabularyKey AddrPoBox { get; private set; }
        public VocabularyKey AddrSubUrb { get; private set; }
        public VocabularyKey AddrTownCity { get; private set; }
        public VocabularyKey AddrPostCode { get; private set; }
        public VocabularyKey AddrUnitType { get; private set; }
        public VocabularyKey AddrBuilding { get; private set; }
        public VocabularyKey AddrState { get; private set; }
        public VocabularyKey AddrFloor { get; private set; }
        public VocabularyKey AddrCountry { get; private set; }
        public VocabularyKey AddrStrType { get; private set; }
        public VocabularyKey AddrDirection { get; private set; }
        public VocabularyKey AddrCounty { get; private set; }
        public VocabularyKey AddrSubdivisn { get; private set; }
        public VocabularyKey AddrPostCode2 { get; private set; }
        public VocabularyKey Spare43 { get; private set; }
        public VocabularyKey BillPer { get; private set; }
        public VocabularyKey BillSeq { get; private set; }
        public VocabularyKey NextDate { get; private set; }
        public VocabularyKey MeterLoc { get; private set; }
        public VocabularyKey LastDate { get; private set; }
        public VocabularyKey District { get; private set; }
        public VocabularyKey PrevNoDays { get; private set; }
        public VocabularyKey LreadDate { get; private set; }
        public VocabularyKey GasGate { get; private set; }
        public VocabularyKey NstType { get; private set; }
        public VocabularyKey LbillType { get; private set; }
        public VocabularyKey Spare55 { get; private set; }
        public VocabularyKey EstSuppress { get; private set; }
        public VocabularyKey EstOrideDate { get; private set; }
        public VocabularyKey EstOrideType { get; private set; }
        public VocabularyKey Spare59 { get; private set; }
        public VocabularyKey OwnAcct { get; private set; }
        public VocabularyKey LegalPaddrFreeForm { get; private set; }
        public VocabularyKey LegalPaddrUnit { get; private set; }
        public VocabularyKey LegalPaddrHouse { get; private set; }
        public VocabularyKey LegalPaddrStreet { get; private set; }
        public VocabularyKey LegalPaddrPoBox { get; private set; }
        public VocabularyKey LegalPaddrSubUrb { get; private set; }
        public VocabularyKey LegalPaddrTownCity { get; private set; }
        public VocabularyKey LegalPaddrPostCode { get; private set; }
        public VocabularyKey LegalPaddrUnitType { get; private set; }
        public VocabularyKey LegalPaddrBuilding { get; private set; }
        public VocabularyKey LegalPaddrState { get; private set; }
        public VocabularyKey LegalPaddrFloor { get; private set; }
        public VocabularyKey LegalPaddrCountry { get; private set; }
        public VocabularyKey LegalPaddrStrtype { get; private set; }
        public VocabularyKey LegalPaddrDirection { get; private set; }
        public VocabularyKey LegalPaddrCounty { get; private set; }
        public VocabularyKey LegalPaddrSubdivisn { get; private set; }
        public VocabularyKey LegalPaddrPostCode2 { get; private set; }
        public VocabularyKey ChgClass { get; private set; }
        public VocabularyKey Spare63 { get; private set; }
        public VocabularyKey Spare64 { get; private set; }
        public VocabularyKey Spare65 { get; private set; }
        public VocabularyKey Spare66 { get; private set; }
        public VocabularyKey Spare67 { get; private set; }
        public VocabularyKey AltEnergyCo { get; private set; }
        public VocabularyKey AltEnergyDate { get; private set; }
        public VocabularyKey AltEnergyCons { get; private set; }
        public VocabularyKey AltLineCo { get; private set; }
        public VocabularyKey AltLineDate { get; private set; }
        public VocabularyKey MeshBlock { get; private set; }
        public VocabularyKey FutureCons { get; private set; }
        public VocabularyKey KeyNumber { get; private set; }
        public VocabularyKey ConnectDate { get; private set; }
        public VocabularyKey DisconnectType { get; private set; }
        public VocabularyKey Disconnect { get; private set; }
        public VocabularyKey DisconnectReason { get; private set; }
        public VocabularyKey ReconnectAuth { get; private set; }
        public VocabularyKey ReconnectDate { get; private set; }
        public VocabularyKey HvFlag { get; private set; }
        public VocabularyKey NominatedKva { get; private set; }
        public VocabularyKey MetNetwork { get; private set; }
        public VocabularyKey Spare85 { get; private set; }
        public VocabularyKey ControlKva { get; private set; }
        public VocabularyKey DisconnectLoc { get; private set; }
        public VocabularyKey Altitude { get; private set; }
        public VocabularyKey LineFactor { get; private set; }
        public VocabularyKey NwCostFchg { get; private set; }
        public VocabularyKey NwCostFchgMult { get; private set; }
        public VocabularyKey AltEnergyEndDate { get; private set; }
        public VocabularyKey UtilityType { get; private set; }
        public VocabularyKey TieredInx { get; private set; }
        public VocabularyKey Spare95 { get; private set; }
        public VocabularyKey Spare96 { get; private set; }
        public VocabularyKey Spare97 { get; private set; }
        public VocabularyKey Spare98 { get; private set; }
        public VocabularyKey Spare99 { get; private set; }
        public VocabularyKey Spare100 { get; private set; }
        public VocabularyKey FullAddress { get; private set; }
    }
}
