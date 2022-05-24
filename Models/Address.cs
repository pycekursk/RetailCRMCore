using Newtonsoft.Json;

using System.ComponentModel;

namespace RetailCRMCore.Models
{
  //public class Address
  //{
  //  [JsonProperty("index")]
  //  [DisplayName("ISO код страны")]
  //  public string CountryIsoCode { get; set; }

  //  public string Country { get; set; }
  //  public string FederalDistrict { get; set; }
  //  [DisplayName("Время доставки")]
  //  public DateTime DeliveryTime { get; set; }

  //  [JsonProperty("index")]
  //  [DisplayName("Индекс")]
  //  public string PostalCode { get; set; }
  //  [DisplayName("Регион")]
  //  public string Region { get; set; }

  //  public string RegionWithType { get; set; }

  //  [DisplayName("Идентификатор региона")]
  //  public long RegionKladrId { get; set; }
  //  public string RegionFiasId { get; set; }
  //  public string RegionIsoCode { get; set; }

  //  [DisplayName("Город")]
  //  public string City { get; set; }
  //  [DisplayName("Идентификатор города")]
  //  public long CityKladrId { get; set; }
  //  public string CityFiasId { get; set; }
  //  public string CityIsoCode { get; set; }
  //  [DisplayName("Тип населенного пункта")]
  //  public string CityType { get; set; }
  //  [DisplayName("Улица")]
  //  public string Street { get; set; }

  //  public string StreetFiasId { get; set; }
  //  public long StreetKladrId { get; set; }


  //  [DisplayName("Тип улицы")]
  //  public string StreetType { get; set; }
  //  [DisplayName("Дом")]
  //  public string Building { get; set; }
  //  [DisplayName("Строение")]
  //  public string House { get; set; }
  //  [DisplayName("Корпус")]
  //  public string Housing { get; set; }
  //  [DisplayName("Подъезд")]
  //  public int? Block { get; set; }
  //  [DisplayName("Номер квартиры/офиса")]
  //  public string Flat { get; set; }
  //  [DisplayName("Этаж")]
  //  public int? Floor { get; set; }
  //  [DisplayName("Метро")]
  //  public string Metro { get; set; }

  //  [JsonProperty("text")]
  //  [DisplayName("Адрес в текстовом виде")]
  //  public string Text { get; set; }
  //  [DisplayName("Примечания к адресу")]
  //  public string Notes { get; set; }
  //  [DisplayName("Адрес пустой")]
  //  public bool IsEmpty { get; set; }

  //  public string GeoLat { get; set; }
  //  public string GeoLon { get; set; }

  //  public override string ToString()
  //  {
  //    return $"{RegionWithType}, {CityType} {City}, {StreetType} {Street} {Building}, {Flat}";
  //  }

  //  //TODO: дополнить оператором преобразования в location
  //}


  public class Address
  {
    public string index { get; set; }
    public string region { get; set; }
    public int regionId { get; set; }
    public string city { get; set; }
    public int cityId { get; set; }
    public string cityType { get; set; }
    public string street { get; set; }
    public int streetId { get; set; }
    public string streetType { get; set; }
    public string building { get; set; }
    public string flat { get; set; }
    public string text { get; set; }
    public int? block { get; set; }
    public string? metro { get; set; }
    public string countryIso { get; set; }
    public int? floor { get; set; }
  }
}