namespace RetailCRMCore.Models
{
  /// <summury>
  /// Служба доставки
  /// </summury>
  public class DeliveryService
  {
    /// <summary>
    /// Название
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Символьный код
    /// </summary>
    public string code { get; set; }

    /// <summary>
    /// Тип доставки
    /// </summary>
    public string deliveryType { get; set; }

    /// <summary>
    /// Статус активности
    /// </summary>
    public bool active { get; set; }

  }
}