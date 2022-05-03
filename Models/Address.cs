using System.ComponentModel;

namespace RetailCRMCore.Models
{
  //public class Address
  //{
  //  public int id { get; set; }
  //  public string city { get; set; }
  //  public string street { get; set; }
  //  public string house { get; set; }
  //  public string text { get; set; }
  //  public string building { get; set; }
  //}

  public class Address
  {
    [DisplayName("ISO код страны")]
    public string countryIso { get; set; }
    [DisplayName("Время доставки")]
    public DateTime deliveryTime { get; set; }
    [DisplayName("Индекс")]
    public string index { get; set; }
    [DisplayName("Регион")]
    public string region { get; set; }
    [DisplayName("Идентификатор региона в Geohelper")]
    public int regionId { get; set; }
    [DisplayName("Город")]
    public string city { get; set; }
    [DisplayName("Идентификатор города в Geohelper")]
    public int cityId { get; set; }
    [DisplayName("Тип населенного пункта")]
    public string cityType { get; set; }
    [DisplayName("Улица")]
    public string street { get; set; }
    [DisplayName("Идентификатор улицы в Geohelper")]
    public int streetId { get; set; }
    [DisplayName("Тип улицы")]
    public string streetType { get; set; }
    [DisplayName("Дом")]
    public string building { get; set; }
    [DisplayName("Строение")]
    public string house { get; set; }
    [DisplayName("Корпус")]
    public string housing { get; set; }
    [DisplayName("Подъезд")]
    public int? block { get; set; }
    [DisplayName("Номер квартиры/офиса")]
    public string flat { get; set; }
    [DisplayName("Этаж")]
    public int? floor { get; set; }
    [DisplayName("Метро")]
    public string metro { get; set; }
    [DisplayName("Адрес в текстовом виде")]
    public string text { get; set; }
    [DisplayName("Примечания к адресу")]
    public string notes { get; set; }
    [DisplayName("Адрес пустой")]
    public bool isEmpty { get; set; }
  }
}