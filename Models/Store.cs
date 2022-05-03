namespace RetailCRMCore.Models
{
  /// <summury>
  /// Склад
  /// </summury>
  public class Store
  {
    /// <summary>
    /// ID склада
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Статус активности
    /// </summary>
    public bool active { get; set; }

    /// <summary>
    /// Порядок
    /// </summary>
    public string ordering { get; set; }

    /// <summary>
    /// Описание склада
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// Адрес склада
    /// </summary>
    public Address address { get; set; }

    /// <summary>
    /// Тип склада (store-type-retail - розничный магазин, store-type-online - интернет-магазин, store-type-warehouse - склад, store-type-supplier - склад поставщика)
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// Внешний ID
    /// </summary>
    public string externalId { get; set; }

    /// <summary>
    /// Телефон склада
    /// </summary>
    public Phone phone { get; set; }

    /// <summary>
    /// Контактное лицо на складе
    /// </summary>
    public string contact { get; set; }

    /// <summary>
    /// Дата создания склада в системе
    /// </summary>
    public DateTime createdAt { get; set; }

    /// <summary>
    /// Символьный код
    /// </summary>
    public string code { get; set; }

    /// <summary>
    /// Email склада
    /// </summary>
    public string email { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string name { get; set; }

  }
}