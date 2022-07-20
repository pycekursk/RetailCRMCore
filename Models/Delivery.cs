using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.ComponentModel.DataAnnotations;

namespace RetailCRMCore.Models
{
    public class Delivery
    {
        public string code { get; set; }
        public string integrationCode { get; set; }
        public double? cost { get; set; } = null;
        public double? netCost { get; set; } = null;
        public string date { get; set; }
        public string vatRate { get; set; }
        public Address? address { get; set; }
        public TimeInterval time { get; set; }

        //[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        //public DeliveryService service { get; set; }

        [JsonProperty("data")]
        public GenericData data { get; set; }
    }

    public class DeliveryData
    {
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool locked { get; set; } = true;

        [JsonProperty("payerType", NullValueHandling = NullValueHandling.Ignore)]
        public string payerType { get; set; }

        [JsonProperty("tariff", NullValueHandling = NullValueHandling.Ignore)]
        public string tariff { get; set; }

        [JsonProperty("tariffName", NullValueHandling = NullValueHandling.Ignore)]
        public string tariffName { get; set; }

        [JsonProperty("extraData", NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryExtraData extraData { get; set; }

        [JsonProperty("pickuppointId", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointId { get; set; }

        [JsonProperty("pickuppointAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointAddress { get; set; }

        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public string days { get; set; }

        [JsonProperty("pickuppointSchedule", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointSchedule { get; set; }

        [JsonProperty("pickuppointPhone", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointPhone { get; set; }

        [JsonProperty("pickuppointName", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointName { get; set; }

        [JsonProperty("pickuppointCoordinateLatitude", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointCoordinateLatitude { get; set; }

        [JsonProperty("pickuppointCoordinateLongitude", NullValueHandling = NullValueHandling.Ignore)]
        public string pickuppointCoordinateLongitude { get; set; }

        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public double? cost { get; set; } = null;
    }

    public class DeliveryExtraData
    {
        [JsonProperty("partner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string partner { get; set; }

        [JsonProperty("paytype", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string paytype { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Paytype
    {
        [Display(Name = "Картой онлайн")]
        NO = 1,

        [Display(Name = "Картой курьеру")]
        CARD = 2,

        [Display(Name = "Наличными курьеру")]
        CASH = 3
    }
}