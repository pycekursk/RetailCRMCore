namespace RetailCRMCore.Models
{
  /// <summury>
  /// Платёж
  /// </summury>
  public class Payment
  {
    /// <summary>
    /// Внутренний ID
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Статус оплаты
    /// </summary>
    public string status { get; set; }

    /// <summary>
    /// Тип оплаты
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// Внешний ID платежа
    /// </summary>
   // public string externalId { get; set; }

    /// <summary>
    /// Сумма платежа
    /// </summary>
    public double amount { get; set; }

    /// <summary>
    /// Дата оплаты. Не забывайте проверять статус оплаты
    /// </summary>
    public DateTime paidAt { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
   // public string comment { get; set; }
  }
}