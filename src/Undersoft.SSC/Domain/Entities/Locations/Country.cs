
using Undersoft.SDK.Service.Data.Object;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Undersoft.SSC.Domain.Entities.Locations
{
    public partial class Country : DataObject
    {
        public string? Name { get; set; }

        public string? CountryCode { get; set; }

        public string? Continent { get; set; }

        public string? TimeZone { get; set; }

        public long? CurrencyId { get; set; }
        public virtual Currency? Currency { get; set; }

        public long? LanguageId { get; set; }
        public virtual Language? Language { get; set; }

        public virtual RelatedSet<CountryState>? CountryStates { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual RelatedSet<Address>? Addresses { get; set; }
    }
}
