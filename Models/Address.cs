using Newtonsoft.Json;

using System.ComponentModel;

namespace RetailCRMCore.Models
{
    public class SuggestionAddress
    {
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? CountryIsoCode { get; set; }

        public Guid RegionFiasId { get; set; }
        public long? RegionKladrId { get; set; }
        public string? RegionIsoCode { get; set; }
        public string? RegionWithType { get; set; }
        public string? RegionType { get; set; }
        public string? RegionTypeFull { get; set; }
        public string? Region { get; set; }

        public Guid CityFiasId { get; set; }
        public long? CityKladrId { get; set; }
        public string? CityWithType { get; set; }
        public string? CityType { get; set; }
        public string? CityTypeFull { get; set; }
        public string? City { get; set; }

        public Guid StreetFiasId { get; set; }
        public long? StreetKladrId { get; set; }
        public string? StreetWithType { get; set; }
        public string? StreetType { get; set; }
        public string? StreetTypeFull { get; set; }
        public string? Street { get; set; }

        public Guid HouseFiasId { get; set; }
        public long? HouseKladrId { get; set; }
        public string? HouseType { get; set; }
        public string? HouseTypeFull { get; set; }
        public string? House { get; set; }


        public Guid FlatFiasId { get; set; }
        public string? FlatType { get; set; }
        public string? FlatTypeFull { get; set; }
        public string? Flat { get; set; }

        public static implicit operator Address(SuggestionAddress suggestionAddress)
        {
            Address address = new();
            //address.region = $"{suggestionAddress.Region} {suggestionAddress.RegionTypeFull}";
            //address.index = suggestionAddress.PostalCode;

            string? addressText = $"{suggestionAddress.Region} {suggestionAddress.RegionTypeFull}, {suggestionAddress.CityTypeFull} {suggestionAddress.City}, {suggestionAddress.StreetTypeFull} {suggestionAddress.Street}, {suggestionAddress.HouseTypeFull} {suggestionAddress.House}, {suggestionAddress.FlatTypeFull} {suggestionAddress.Flat}";

            address.text = addressText;

            return address;
        }
    }



    public class Address
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? index { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? region { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? regionId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? city { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? cityId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? cityType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? street { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? streetId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? streetType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? building { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? house { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? flat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? text { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? block { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? metro { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? countryIso { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? floor { get; set; }

        public override string ToString()
        {
            string text = $"{new Func<string, string>((s) => s == null ? "" : $"{s}, ").Invoke(region)}{new Func<string, string>((s) => s == null ? "" : $"{cityType} ").Invoke(cityType)}{new Func<string, string>((s) => s == null ? "" : $"{s}, ").Invoke(city)}{new Func<string, string>((s) => s == null ? "" : $"{s} ").Invoke(streetType)}{new Func<string, string>((s) => s == null ? "" : $"{s}, ").Invoke(street)}{new Func<string, string>((s) => s == null ? "" : $"{s}").Invoke(house)}";
            text = text.TrimEnd(new char[] { ',', ' ' });
            return text;
        }
    }
}