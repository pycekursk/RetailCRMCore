using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.ComponentModel.DataAnnotations;

namespace RetailCRMCore.Models
{
    public class Delivery
    {
        public string code { get; set; }
        public double cost { get; set; }
        public double netCost { get; set; }
        public string date { get; set; }
        public string vatRate { get; set; }
        public Address address { get; set; }
        public TimeInterval time { get; set; }
        public DeliveryService service { get; set; }
        [JsonProperty("data")]
        public DeliveryData data { get; set; }
    }


    public class DeliveryData
    {
        [JsonProperty("locked")]
        public bool locked { get; set; } = true;

        [JsonProperty("cost")]
        public double cost { get; set; }

        [JsonProperty("payerType")]
        public string payerType { get; set; }

        [JsonProperty("tariff")]
        public string tariff { get; set; }

        //[JsonIgnore]
        [JsonProperty("extraData")]
        public DeliveryExtraData extraData { get; set; }

        [JsonProperty("pickuppointId")]
        public string pickuppointId { get; set; }
    }

    public class DeliveryExtraData
    {
        [JsonProperty("partner")]
        public string partner { get; set; }

        [JsonProperty("paytype")]
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