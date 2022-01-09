using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Powerwater.Vocabularies
{
    public class  LocationVocabulary : SimpleVocabulary
    {
        public  LocationVocabulary()
        {
            VocabularyName = "Powerwater Location"; 
            KeyPrefix      = "powerwater.location"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Location.Address; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Powerwater Location Details", group =>
            {
                FullName = group.Add(new VocabularyKey("FullName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitNumber = group.Add(new VocabularyKey("UnitNumber", "Unit Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey("StreetNumber", "Street Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetName = group.Add(new VocabularyKey("StreetName", "Street Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.

            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
            AddMapping(StreetNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressStreetNumber);
            AddMapping(StreetName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
        }


        
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey UnitNumber { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey StreetName { get; private set; }
        public VocabularyKey City { get; private set; }
        
    }
}
