using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetailCRMCore.Models
{

  /// <summury>
  /// Торговое предложение (SKU)
  /// </summury>
  public class Offer
  {
    private object _properties;

    [JsonIgnore]
    private Model model;
    [JsonIgnore]
    private Size size;
    [JsonIgnore]
    private string? printSize;
    [JsonIgnore]
    private string? material;

    /// <summary>
    /// ID торгового предложения
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Возвращает название товара иначе название SKU
    /// </summary>
    public string offerName { get; set; }

    /// <summary>
    /// Название SKU
    /// </summary>
    public string displayName { get; set; }

    public bool active { get; set; }

    /// <summary>
    /// Артикул
    /// </summary>
    public string article { get; set; }

    /// <summary>
    /// Артикул торгового предложения или товара, если артикул SKU отсутствует
    /// </summary>
    public string anyArticle { get; set; }

    /// <summary>
    /// Возвращает цену SKU иначе цену товара, к которому относится SKU
    /// </summary>
    public float actualPrice { get; set; }

    /// <summary>
    /// Цена SKU (priceType - код типа цены, если необходимо выбрать цену определенного типа)
    /// </summary>
    public float price { get; set; }

    /// <summary>
    /// Закупочная цена SKU
    /// </summary>
    public float purchasePrice { get; set; }

    /// <summary>
    /// Свойства SKU
    /// </summary>

    public object properties
    {
      get => _properties;
      set
      {
        try
        {
          JsonElement _model = new JsonElement();
          ((JsonElement)value).TryGetProperty("model", out _model);
          Enum.TryParse(_model.ToString(), out model);

          JsonElement _size = new JsonElement();
          ((JsonElement)value).TryGetProperty("razmer", out _size);
          Enum.TryParse(_size.ToString(), out size);

          JsonElement _material = new JsonElement();
          ((JsonElement)value).TryGetProperty("sostav", out _material);
          material = _material.ToString();

          JsonElement _printSize = new JsonElement();
          ((JsonElement)value).TryGetProperty("razmer_printa", out _printSize);
          printSize = _printSize.ToString();
        }
        catch
        {

        }
        _properties = value;
      }
    }

    [JsonIgnore]
    public string? Material
    {
      get => material;
      set
      {
        material = value;
        //var obj = ((JsonElement)properties).Deserialize<dynamic>(); 
      }
    }
    [JsonIgnore]
    public string? PrintSize { get => printSize; set => printSize = value; }

    [JsonIgnore]
    public Model Model { get => model; set => model = value; }
    [JsonIgnore]
    public Size Size { get => size; set => size = value; }

    /// <summary>
    /// Товар, к которому относится SKU
    /// </summary>
    public Product product { get; set; }

    /// <summary>
    /// Доступное количество
    /// </summary>
    public int quantity { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// ID торгового предложения в магазине
    /// </summary>
    public string externalId { get; set; }

    /// <summary>
    /// ID торгового предложения в складской системе
    /// </summary>
    public string xmlId { get; set; }

    /// <summary>
    /// Каталог
    /// </summary>
    public Catalog catalog { get; set; }

    /// <summary>
    /// deprecated Магазин. Используйте getCatalog()
    /// </summary>
    public Site site { get; set; }

    /// <summary>
    /// Дата создания в системе
    /// </summary>
    public DateTime createdAt { get; set; }

    /// <summary>
    /// Адрес изображения
    /// </summary>
    public string imageUrl { get; set; }

    /// <summary>
    /// Единица измерения
    /// </summary>
    public Unit unit { get; set; }

    /// <summary>
    /// Ставка НДС
    /// </summary>
    public string vatRate { get; set; }

    /// <summary>
    /// Штрих-код
    /// </summary>
    public string barcode { get; set; }

    /// <summary>
    /// Вес
    /// </summary>
    public int weight { get; set; }

    public string[] images { get; set; }

  }

  public enum Model
  {
    [Display(Name = "Oversize")]
    Oversize = 2,
    [Display(Name = "Normal")]
    Normal = 1,
    Default = 0
  }

  public enum Size
  {
    XS,
    S,
    M = 0,
    L,
    XL
  }
}