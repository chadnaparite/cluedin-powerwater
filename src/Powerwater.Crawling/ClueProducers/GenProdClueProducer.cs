using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Powerwater.Vocabularies;
using CluedIn.Crawling.Powerwater.Core.Models;

namespace CluedIn.Crawling.Powerwater.ClueProducers
{
    public class GenProdClueProducer : BaseClueProducer<GenProd>
    {
        private readonly IClueFactory factory;

        public GenProdClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(GenProd input, Guid accountId)
        {
            var genprodVocabulary = new GenProdVocabulary();
            var clue = factory.Create(genprodVocabulary.Grouping, input.Install.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.Install != null)
            {
                data.Name = input.Install;
                data.DisplayName = input.Install;
            }

            if (input.MrFlagRm != null)
            {
                data.Description = input.MrFlagRm;
            }

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            //

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[genprodVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[genprodVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[genprodVocabulary.Install] = input.Install.PrintIfAvailable();
            data.Properties[genprodVocabulary.Meter] = input.Meter.PrintIfAvailable();
            data.Properties[genprodVocabulary.UnbillMeter] = input.UnbillMeter.PrintIfAvailable();
            data.Properties[genprodVocabulary.PrevMeter] = input.PrevMeter.PrintIfAvailable();
            data.Properties[genprodVocabulary.MasInstall] = input.MasInstall.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare5] = input.Spare5.PrintIfAvailable();
            data.Properties[genprodVocabulary.KvaRating] = input.KvaRating.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare7] = input.Spare7.PrintIfAvailable();
            data.Properties[genprodVocabulary.Fcharge] = input.Fcharge.PrintIfAvailable();
            data.Properties[genprodVocabulary.Fcdesc] = input.Fcdesc.PrintIfAvailable();
            data.Properties[genprodVocabulary.FchargeMultp] = input.FchargeMultp.PrintIfAvailable();
            data.Properties[genprodVocabulary.FcstDate] = input.FcstDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.FcenDate] = input.FcenDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare13] = input.Spare13.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare14] = input.Spare14.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare15] = input.Spare15.PrintIfAvailable();
            data.Properties[genprodVocabulary.TouenDate] = input.TouenDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.ToustDate] = input.ToustDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare18] = input.Spare18.PrintIfAvailable();
            data.Properties[genprodVocabulary.CpIdent] = input.CpIdent.PrintIfAvailable();
            data.Properties[genprodVocabulary.CtNumber] = input.CtNumber.PrintIfAvailable();
            data.Properties[genprodVocabulary.SubStation] = input.SubStation.PrintIfAvailable();
            data.Properties[genprodVocabulary.Shutdown] = input.Shutdown.PrintIfAvailable();
            data.Properties[genprodVocabulary.TouFlag] = input.TouFlag.PrintIfAvailable();
            data.Properties[genprodVocabulary.TouCharge] = input.TouCharge.PrintIfAvailable();
            data.Properties[genprodVocabulary.TouDesc] = input.TouDesc.PrintIfAvailable();
            data.Properties[genprodVocabulary.MrFlag] = input.MrFlag.PrintIfAvailable();
            data.Properties[genprodVocabulary.MrFlagRm] = input.MrFlagRm.PrintIfAvailable();
            data.Properties[genprodVocabulary.PostEdit] = input.PostEdit.PrintIfAvailable();
            data.Properties[genprodVocabulary.NzedCode] = input.NzedCode.PrintIfAvailable();
            data.Properties[genprodVocabulary.PropNo] = input.PropNo.PrintIfAvailable();
            data.Properties[genprodVocabulary.Consumer] = input.Consumer.PrintIfAvailable();
            data.Properties[genprodVocabulary.MrNotes] = input.MrNotes.PrintIfAvailable();
            data.Properties[genprodVocabulary.Pissue] = input.Pissue.PrintIfAvailable();
            data.Properties[genprodVocabulary.AppCodes] = input.AppCodes.PrintIfAvailable();
            data.Properties[genprodVocabulary.AppQty] = input.AppQty.PrintIfAvailable();
            data.Properties[genprodVocabulary.AppKw] = input.AppKw.PrintIfAvailable();
            data.Properties[genprodVocabulary.AppControl] = input.AppControl.PrintIfAvailable();
            data.Properties[genprodVocabulary.Location] = input.Location.PrintIfAvailable();
            data.Properties[genprodVocabulary.Wissue] = input.Wissue.PrintIfAvailable();
            data.Properties[genprodVocabulary.SiteNo] = input.SiteNo.PrintIfAvailable();
            data.Properties[genprodVocabulary.RelayNo] = input.RelayNo.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrFreeform] = input.AddrFreeform.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrUnit] = input.AddrUnit.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrHouse] = input.AddrHouse.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrStreet] = input.AddrStreet.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrPoBox] = input.AddrPoBox.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrSubUrb] = input.AddrSubUrb.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrTownCity] = input.AddrTownCity.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrPostCode] = input.AddrPostCode.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrUnitType] = input.AddrUnitType.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrBuilding] = input.AddrBuilding.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrState] = input.AddrState.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrFloor] = input.AddrFloor.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrCountry] = input.AddrCountry.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrStrType] = input.AddrStrType.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrDirection] = input.AddrDirection.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrCounty] = input.AddrCounty.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrSubdivisn] = input.AddrSubdivisn.PrintIfAvailable();
            data.Properties[genprodVocabulary.AddrPostCode2] = input.AddrPostCode2.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare43] = input.Spare43.PrintIfAvailable();
            data.Properties[genprodVocabulary.BillPer] = input.BillPer.PrintIfAvailable();
            data.Properties[genprodVocabulary.BillSeq] = input.BillSeq.PrintIfAvailable();
            data.Properties[genprodVocabulary.NextDate] = input.NextDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.MeterLoc] = input.MeterLoc.PrintIfAvailable();
            data.Properties[genprodVocabulary.LastDate] = input.LastDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.District] = input.District.PrintIfAvailable();
            data.Properties[genprodVocabulary.PrevNoDays] = input.PrevNoDays.PrintIfAvailable();
            data.Properties[genprodVocabulary.LreadDate] = input.LreadDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.GasGate] = input.GasGate.PrintIfAvailable();
            data.Properties[genprodVocabulary.NstType] = input.NstType.PrintIfAvailable();
            data.Properties[genprodVocabulary.LbillType] = input.LbillType.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare55] = input.Spare55.PrintIfAvailable();
            data.Properties[genprodVocabulary.EstSuppress] = input.EstSuppress.PrintIfAvailable();
            data.Properties[genprodVocabulary.EstOrideDate] = input.EstOrideDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.EstOrideType] = input.EstOrideType.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare59] = input.Spare59.PrintIfAvailable();
            data.Properties[genprodVocabulary.OwnAcct] = input.OwnAcct.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrFreeForm] = input.LegalPaddrFreeForm.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrUnit] = input.LegalPaddrUnit.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrHouse] = input.LegalPaddrHouse.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrStreet] = input.LegalPaddrStreet.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrPoBox] = input.LegalPaddrPoBox.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrSubUrb] = input.LegalPaddrSubUrb.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrTownCity] = input.LegalPaddrTownCity.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrPostCode] = input.LegalPaddrPostCode.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrUnitType] = input.LegalPaddrUnitType.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrBuilding] = input.LegalPaddrBuilding.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrState] = input.LegalPaddrState.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrFloor] = input.LegalPaddrFloor.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrCountry] = input.LegalPaddrCountry.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrStrtype] = input.LegalPaddrStrtype.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrDirection] = input.LegalPaddrDirection.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrCounty] = input.LegalPaddrCounty.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrSubdivisn] = input.LegalPaddrSubdivisn.PrintIfAvailable();
            data.Properties[genprodVocabulary.LegalPaddrPostCode2] = input.LegalPaddrPostCode2.PrintIfAvailable();
            data.Properties[genprodVocabulary.ChgClass] = input.ChgClass.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare63] = input.Spare63.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare64] = input.Spare64.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare65] = input.Spare65.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare66] = input.Spare66.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare67] = input.Spare67.PrintIfAvailable();
            data.Properties[genprodVocabulary.AltEnergyCo] = input.AltEnergyCo.PrintIfAvailable();
            data.Properties[genprodVocabulary.AltEnergyDate] = input.AltEnergyDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.AltEnergyCons] = input.AltEnergyCons.PrintIfAvailable();
            data.Properties[genprodVocabulary.AltLineCo] = input.AltLineCo.PrintIfAvailable();
            data.Properties[genprodVocabulary.AltLineDate] = input.AltLineDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.MeshBlock] = input.MeshBlock.PrintIfAvailable();
            data.Properties[genprodVocabulary.FutureCons] = input.FutureCons.PrintIfAvailable();
            data.Properties[genprodVocabulary.KeyNumber] = input.KeyNumber.PrintIfAvailable();
            data.Properties[genprodVocabulary.ConnectDate] = input.ConnectDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.DisconnectType] = input.DisconnectType.PrintIfAvailable();
            data.Properties[genprodVocabulary.Disconnect] = input.Disconnect.PrintIfAvailable();
            data.Properties[genprodVocabulary.DisconnectReason] = input.DisconnectReason.PrintIfAvailable();
            data.Properties[genprodVocabulary.ReconnectAuth] = input.ReconnectAuth.PrintIfAvailable();
            data.Properties[genprodVocabulary.ReconnectDate] = input.ReconnectDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.HvFlag] = input.HvFlag.PrintIfAvailable();
            data.Properties[genprodVocabulary.NominatedKva] = input.NominatedKva.PrintIfAvailable();
            data.Properties[genprodVocabulary.MetNetwork] = input.MetNetwork.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare85] = input.Spare85.PrintIfAvailable();
            data.Properties[genprodVocabulary.ControlKva] = input.ControlKva.PrintIfAvailable();
            data.Properties[genprodVocabulary.DisconnectLoc] = input.DisconnectLoc.PrintIfAvailable();
            data.Properties[genprodVocabulary.Altitude] = input.Altitude.PrintIfAvailable();
            data.Properties[genprodVocabulary.LineFactor] = input.LineFactor.PrintIfAvailable();
            data.Properties[genprodVocabulary.NwCostFchg] = input.NwCostFchg.PrintIfAvailable();
            data.Properties[genprodVocabulary.NwCostFchgMult] = input.NwCostFchgMult.PrintIfAvailable();
            data.Properties[genprodVocabulary.AltEnergyEndDate] = input.AltEnergyEndDate.PrintIfAvailable();
            data.Properties[genprodVocabulary.UtilityType] = input.UtilityType.PrintIfAvailable();
            data.Properties[genprodVocabulary.TieredInx] = input.TieredInx.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare95] = input.Spare95.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare96] = input.Spare96.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare97] = input.Spare97.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare98] = input.Spare98.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare99] = input.Spare99.PrintIfAvailable();
            data.Properties[genprodVocabulary.Spare100] = input.Spare100.PrintIfAvailable();
            data.Properties[genprodVocabulary.FullAddress] = input.FullAddress.PrintIfAvailable();

            return clue;
        }
    }
}
