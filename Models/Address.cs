using Newtonsoft.Json;

using System.ComponentModel;

namespace RetailCRMCore.Models
{
    public class Address
    {
        public string index { get; set; }
        public string? region { get; set; }
        public int? regionId { get; set; }
        public string? city { get; set; }
        public int? cityId { get; set; }
        public string? cityType { get; set; }
        public string? street { get; set; }
        public int? streetId { get; set; }
        public string? streetType { get; set; }
        public string building { get; set; }
        public string house { get; set; }
        public string flat { get; set; }
        public string? text { get; set; }
        public int? block { get; set; }
        public string? metro { get; set; }
        public string countryIso { get; set; }
        public int? floor { get; set; }

        public override string ToString()
        {
            string text = $"{new Func<string, string>((s) => s == null ? "" : $"{s}, ").Invoke(region)}{new Func<string, string>((s) => s == null ? "" : $"{cityType} ").Invoke(cityType)}{new Func<string, string>((s) => s == null ? "" : $"{s}, ").Invoke(city)}{new Func<string, string>((s) => s == null ? "" : $"{s} ").Invoke(streetType)}{new Func<string, string>((s) => s == null ? "" : $"{s}, ").Invoke(street)}{new Func<string, string>((s) => s == null ? "" : $"{s}").Invoke(house)}";
            text = text.TrimEnd(new char[] { ',', ' ' });
            return text;
        }
    }
}