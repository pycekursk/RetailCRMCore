namespace RetailCRMCore.Models
{
  /// <summury>
  /// Статус оплаты
  /// </summury>
  public class PaymentStatus
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
    /// Порядок
    /// </summary>
    public string ordering { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// Внешний ID
    /// </summary>
    public string externalId { get; set; }

    /// <summary>
    /// Признак того, что заказ оплачен
    /// </summary>
    public bool paymentComplete { get; set; }

    /// <summary>
    /// Признак того, что заказ оплачен
    /// </summary>
    public bool isPaymentComplete { get; set; }

  }
}