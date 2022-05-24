namespace RetailCRMCore.Models
{
  /// <summury>
  /// Тип оплаты
  /// </summury>
  public class PaymentType
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
    /// Статус активности
    /// </summary>
    public bool active { get; set; }

    /// <summary>
    /// Устанавливается по-умолчанию для заказов, создаваемых в системе
    /// </summary>
    public bool defaultForCrm { get; set; }

    /// <summary>
    /// Устанавливается по-умолчанию для заказов, создаваемых через API
    /// </summary>
    public bool defaultForApi { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
    public string description { get; set; }

    public string[] deliveryTypes { get; set; }

    public string[] paymentStatuses { get; set; }

    public IntegrationModule? integrationModule { get; set; }
  }
}