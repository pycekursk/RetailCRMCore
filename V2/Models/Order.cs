using System;
using System.Collections.Generic;

using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using RetailCRMCore.Models;


namespace RetailCRMCore.V2.Models
{

    public class TimeInterval
    {
        /// <summary>
        /// Время "с"
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime From { get; set; }

        /// <summary>
        /// Время "до"
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime To { get; set; }

        /// <summary>
        /// Временной диапазон в свободной форме
        /// </summary>
        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public string Custom { get; set; }
    }

    public class Delivery
    {
        /// <summary>
        /// Дата доставки
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Информация о временном диапазоне
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public TimeInterval Time { get; set; }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Address Address { get; set; }
    }

    public class Address
    {
        /// <summary>
        /// Индекс
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// ISO код страны (ISO 3166-1 alpha-2)
        /// </summary>
        [JsonProperty("countryIso", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Идентификатор региона в Geohelper
        /// </summary>
        [JsonProperty("regionId", NullValueHandling = NullValueHandling.Ignore)]
        public int? RegionId { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Идентификатор города в Geohelper
        /// </summary>
        [JsonProperty("cityId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CityId { get; set; }

        /// <summary>
        /// Тип населенного пункта
        /// </summary>
        [JsonProperty("cityType", NullValueHandling = NullValueHandling.Ignore)]
        public string CityType { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
        public string Street { get; set; }

        /// <summary>
        /// Идентификатор улицы в Geohelper
        /// </summary>
        [JsonProperty("streetId", NullValueHandling = NullValueHandling.Ignore)]
        public int StreetId { get; set; }

        /// <summary>
        /// Тип улицы пункта
        /// </summary>
        [JsonProperty("streetType", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetType { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        [JsonProperty("building", NullValueHandling = NullValueHandling.Ignore)]
        public string Building { get; set; }

        /// <summary>
        /// Номер квартиры/офиса
        /// </summary>
        [JsonProperty("flat", NullValueHandling = NullValueHandling.Ignore)]
        public string Flat { get; set; }

        /// <summary>
        /// Этаж
        /// </summary>
        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Floor { get; set; }

        /// <summary>
        /// Подъезд
        /// </summary>
        [JsonProperty("block", NullValueHandling = NullValueHandling.Ignore)]
        public int? Block { get; set; }

        /// <summary>
        /// Строение
        /// </summary>
        [JsonProperty("house", NullValueHandling = NullValueHandling.Ignore)]
        public string House { get; set; }

        /// <summary>
        /// Корпус
        /// </summary>
        [JsonProperty("housing", NullValueHandling = NullValueHandling.Ignore)]
        public string Housing { get; set; }

        /// <summary>
        /// Метро
        /// </summary>
        [JsonProperty("metro", NullValueHandling = NullValueHandling.Ignore)]
        public string Metro { get; set; }

        /// <summary>
        /// Текстовое представление адреса
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        public override string ToString()
        {
            string[] props = new string[] {
                Region,
                City,
                Street,
                Building,
                Flat
            };
            string result = string.Empty;

            for (int i = 0; i < props.Length; i++)
            {
                if (i != 0) result += " ";
                result += props[i] != null ? $"{props[i]}" : "";
            }

            return result;
        }
    }

    public class OrderProduct
    {
        /// <summary>
        /// Цена товара/SKU
        /// </summary>
        [JsonProperty("initialPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double InitialPrice { get; set; }

        /// <summary>
        /// Денежная скидка на единицу товара
        /// </summary>
        [
            JsonProperty(
                "discountManualAmount",
                NullValueHandling = NullValueHandling.Ignore)
        ]
        public double DiscountManualAmount { get; set; }

        /// <summary>
        /// Процентная скидка на единицу товара
        /// </summary>
        [
            JsonProperty(
                "discountManualPercent",
                NullValueHandling = NullValueHandling.Ignore)
        ]
        public double DiscountManualPercent { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public float Quantity { get; set; }
    }

    public class Order
    {
        /// <summary>
        /// Вес
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double Weight { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public int Length { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; set; }

        /// <summary>
        /// OrderProducts
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public OrderProduct[]? Items { get; set; }

        /// <summary>
        /// Дата доставки
        /// </summary>
        [JsonProperty("delivery", NullValueHandling = NullValueHandling.Ignore)]
        public Delivery? Delivery { get; set; }
    }

    public static class Serialize
    {
        public static string ToJson(this Order self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);

        internal static class Converter
        {
            public static readonly JsonSerializerSettings
                Settings =
                    new JsonSerializerSettings
                    {
                        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                        DateParseHandling = DateParseHandling.None,
                        Converters =
                            {
                            new IsoDateTimeConverter {
                                DateTimeStyles = DateTimeStyles.AssumeUniversal
                            }
                            }
                    };
        }
    }



    //<auto-generated />

    //To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:

    //   using yakutsa.Models;

    //   var order = Order.FromJson(jsonString);


    //public partial class Order
    //{
    //    [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Slug { get; set; }

    //    [JsonProperty("bonusesCreditTotal", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BonusesCreditTotal { get; set; }

    //    [JsonProperty("bonusesChargeTotal", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? BonusesChargeTotal { get; set; }

    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Id { get; set; }

    //    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Number { get; set; }

    //    [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
    //    public Guid? ExternalId { get; set; }

    //    [JsonProperty("orderType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string OrderType { get; set; }

    //    [JsonProperty("orderMethod", NullValueHandling = NullValueHandling.Ignore)]
    //    public string OrderMethod { get; set; }

    //    [JsonProperty("privilegeType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PrivilegeType { get; set; }

    //    [JsonProperty("countryIso", NullValueHandling = NullValueHandling.Ignore)]
    //    public string CountryIso { get; set; }

    //    [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
    //    public DateTimeOffset? CreatedAt { get; set; }

    //    [JsonProperty("statusUpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
    //    public DateTimeOffset? StatusUpdatedAt { get; set; }

    //    [JsonProperty("summ", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Summ { get; set; }

    //    [JsonProperty("totalSumm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? TotalSumm { get; set; }

    //    [JsonProperty("prepaySum", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? PrepaySum { get; set; }

    //    [JsonProperty("purchaseSumm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? PurchaseSumm { get; set; }

    //    [JsonProperty("mark", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Mark { get; set; }

    //    [JsonProperty("markDatetime", NullValueHandling = NullValueHandling.Ignore)]
    //    public DateTimeOffset? MarkDatetime { get; set; }

    //    [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
    //    public string LastName { get; set; }

    //    [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
    //    public string FirstName { get; set; }

    //    [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Phone { get; set; }

    //    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Email { get; set; }

    //    [JsonProperty("call", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Call { get; set; }

    //    [JsonProperty("expired", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Expired { get; set; }

    //    [JsonProperty("managerId", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? ManagerId { get; set; }

    //    [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
    //    public Contact Customer { get; set; }

    //    [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
    //    public Contact Contact { get; set; }

    //    [JsonProperty("contragent", NullValueHandling = NullValueHandling.Ignore)]
    //    public Contragent Contragent { get; set; }

    //    [JsonProperty("delivery", NullValueHandling = NullValueHandling.Ignore)]
    //    public Delivery Delivery { get; set; }

    //    [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Site { get; set; }

    //    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Status { get; set; }

    //    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    //    public List<OrderProduct> Items { get; set; } = new List<OrderProduct>();

    //    [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
    //    public Payments Payments { get; set; }

    //    [JsonProperty("fromApi", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? FromApi { get; set; }

    //    [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Weight { get; set; }

    //    [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Length { get; set; }

    //    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Width { get; set; }

    //    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Height { get; set; }

    //    [JsonProperty("shipmentStore", NullValueHandling = NullValueHandling.Ignore)]
    //    public string ShipmentStore { get; set; }

    //    [JsonProperty("shipped", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Shipped { get; set; }

    //    [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] CustomFields { get; set; }

    //    [JsonProperty("patronomic", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Patronomic { get; set; }

    //    [JsonProperty("paymentType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PaymentType { get; set; }
    //}

    //public partial class Contact
    //{
    //    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Type { get; set; }

    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Id { get; set; }

    //    [JsonProperty("isContact", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsContact { get; set; }

    //    [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
    //    public DateTimeOffset? CreatedAt { get; set; }

    //    [JsonProperty("managerId", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? ManagerId { get; set; }

    //    [JsonProperty("vip", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Vip { get; set; }

    //    [JsonProperty("bad", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Bad { get; set; }

    //    [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Site { get; set; }

    //    [JsonProperty("contragent", NullValueHandling = NullValueHandling.Ignore)]
    //    public Contragent Contragent { get; set; }

    //    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] Tags { get; set; }

    //    [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] CustomFields { get; set; }

    //    [JsonProperty("marginSumm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? MarginSumm { get; set; }

    //    [JsonProperty("totalSumm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? TotalSumm { get; set; }

    //    [JsonProperty("averageSumm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? AverageSumm { get; set; }

    //    [JsonProperty("ordersCount", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? OrdersCount { get; set; }

    //    [JsonProperty("costSumm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? CostSumm { get; set; }

    //    [JsonProperty("personalDiscount", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? PersonalDiscount { get; set; }

    //    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    //    public ContactAddress Address { get; set; }

    //    [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
    //    public Segment[] Segments { get; set; }

    //    [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
    //    public string FirstName { get; set; }

    //    [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
    //    public string LastName { get; set; }

    //    [JsonProperty("presumableSex", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PresumableSex { get; set; }

    //    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Email { get; set; }

    //    [JsonProperty("phones", NullValueHandling = NullValueHandling.Ignore)]
    //    public Phone[] Phones { get; set; }
    //}

    //public partial class ContactAddress
    //{
    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Id { get; set; }

    //    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Text { get; set; }
    //}

    //public partial class Contragent
    //{
    //    [JsonProperty("contragentType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string ContragentType { get; set; }
    //}

    //public partial class Phone
    //{
    //    [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Number { get; set; }
    //}

    //public partial class Segment
    //{
    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Id { get; set; }

    //    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Code { get; set; }

    //    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Name { get; set; }

    //    [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
    //    public DateTimeOffset? CreatedAt { get; set; }

    //    [JsonProperty("isDynamic", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? IsDynamic { get; set; }

    //    [JsonProperty("customersCount", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? CustomersCount { get; set; }

    //    [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Active { get; set; }
    //}

    //public partial class Delivery
    //{
    //    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Code { get; set; }

    //    [JsonProperty("integrationCode", NullValueHandling = NullValueHandling.Ignore)]
    //    public string IntegrationCode { get; set; }

    //    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    //    public dynamic Data { get; set; }

    //    [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Cost { get; set; }

    //    [JsonProperty("netCost", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? NetCost { get; set; }

    //    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    //    public DeliveryAddress Address { get; set; }
    //}

    //public partial class DeliveryAddress
    //{
    //    [JsonProperty("countryIso", NullValueHandling = NullValueHandling.Ignore)]
    //    public string CountryIso { get; set; }

    //    [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Region { get; set; }

    //    [JsonProperty("regionId", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? RegionId { get; set; }

    //    [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
    //    public string City { get; set; }

    //    [JsonProperty("cityId", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? CityId { get; set; }

    //    [JsonProperty("cityType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string CityType { get; set; }

    //    [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Street { get; set; }

    //    [JsonProperty("streetId", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? StreetId { get; set; }

    //    [JsonProperty("streetType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string StreetType { get; set; }

    //    [JsonProperty("flat", NullValueHandling = NullValueHandling.Ignore)]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long? Flat { get; set; }

    //    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Text { get; set; }
    //    public string House { get; set; }
    //}

    //public partial class Data
    //{
    //    [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
    //    public bool? Locked { get; set; }

    //    [JsonProperty("pickuppointAddress", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointAddress { get; set; }

    //    [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Days { get; set; }

    //    [JsonProperty("tariff", NullValueHandling = NullValueHandling.Ignore)]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long? Tariff { get; set; }

    //    [JsonProperty("tariffName", NullValueHandling = NullValueHandling.Ignore)]
    //    public string TariffName { get; set; }

    //    [JsonProperty("pickuppointId", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointId { get; set; }

    //    [JsonProperty("pickuppointSchedule", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointSchedule { get; set; }

    //    [JsonProperty("pickuppointPhone", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointPhone { get; set; }

    //    [JsonProperty("payerType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PayerType { get; set; }

    //    [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Cost { get; set; }

    //    [JsonProperty("minTerm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? MinTerm { get; set; }

    //    [JsonProperty("maxTerm", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? MaxTerm { get; set; }

    //    [JsonProperty("pickuppointName", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointName { get; set; }

    //    [JsonProperty("pickuppointCoordinateLatitude", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointCoordinateLatitude { get; set; }

    //    [JsonProperty("pickuppointCoordinateLongitude", NullValueHandling = NullValueHandling.Ignore)]
    //    public string PickuppointCoordinateLongitude { get; set; }

    //    [JsonProperty("extraData", NullValueHandling = NullValueHandling.Ignore)]
    //    public ExtraData ExtraData { get; set; }

    //    [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
    //    public object[] Packages { get; set; }
    //}

    //public partial class ExtraData
    //{
    //    [JsonProperty("partner", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Partner { get; set; }

    //    [JsonProperty("paytype", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Paytype { get; set; }
    //}

    ////public partial class Item
    ////{
    ////  [JsonProperty("bonusesChargeTotal", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? BonusesChargeTotal { get; set; }

    ////  [JsonProperty("bonusesCreditTotal", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? BonusesCreditTotal { get; set; }

    ////  [JsonProperty("markingCodes", NullValueHandling = NullValueHandling.Ignore)]
    ////  public object[] MarkingCodes { get; set; }

    ////  [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
    ////  public object[] Discounts { get; set; }

    ////  [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? Id { get; set; }

    ////  [JsonProperty("initialPrice", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? InitialPrice { get; set; }

    ////  [JsonProperty("discountTotal", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? DiscountTotal { get; set; }

    ////  [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
    ////  public Price[] Prices { get; set; }

    ////  [JsonProperty("vatRate", NullValueHandling = NullValueHandling.Ignore)]
    ////  public string VatRate { get; set; }

    ////  [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
    ////  public DateTimeOffset? CreatedAt { get; set; }

    ////  [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? Quantity { get; set; }

    ////  [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    ////  public string Status { get; set; }

    ////  [JsonProperty("offer", NullValueHandling = NullValueHandling.Ignore)]
    ////  public Offer Offer { get; set; }

    ////  [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
    ////  public object[] Properties { get; set; }

    ////  [JsonProperty("purchasePrice", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? PurchasePrice { get; set; }
    ////}

    ////public partial class Offer
    ////{
    ////  [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
    ////  public string DisplayName { get; set; }

    ////  [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    ////  public long? Id { get; set; }

    ////  [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    ////  public string Name { get; set; }

    ////  [JsonProperty("article", NullValueHandling = NullValueHandling.Ignore)]
    ////  public string Article { get; set; }

    ////  [JsonProperty("vatRate", NullValueHandling = NullValueHandling.Ignore)]
    ////  public string VatRate { get; set; }

    ////  [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
    ////  public Properties Properties { get; set; }

    ////  [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
    ////  public Unit Unit { get; set; }
    ////}

    //public partial class Properties
    //{
    //    [JsonProperty("razmer", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Razmer { get; set; }

    //    [JsonProperty("sostav", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Sostav { get; set; }
    //}

    //public partial class Unit
    //{
    //    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Code { get; set; }

    //    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Name { get; set; }

    //    [JsonProperty("sym", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Sym { get; set; }
    //}

    //public partial class Price
    //{
    //    [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? PricePrice { get; set; }

    //    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Quantity { get; set; }
    //}

    //public partial class Payments
    //{
    //    [JsonProperty("400", NullValueHandling = NullValueHandling.Ignore)]
    //    public The400 The400 { get; set; }
    //}

    //public partial class The400
    //{
    //    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Id { get; set; }

    //    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Status { get; set; }

    //    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    //    public string Type { get; set; }

    //    [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
    //    public long? Amount { get; set; }
    //}

    //public partial class Order
    //{
    //    public static Order FromJson(string json) => JsonConvert.DeserializeObject<Order>(json, Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this Order self) => JsonConvert.SerializeObject(self, Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}

    //internal class ParseStringConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        long l;
    //        if (Int64.TryParse(value, out l))
    //        {
    //            return l;
    //        }
    //        throw new Exception("Cannot unmarshal type long");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (long)untypedValue;
    //        serializer.Serialize(writer, value.ToString());
    //        return;
    //    }

    //    public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    //}

}
