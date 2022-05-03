namespace RetailCRMCore.Models
{
  /// <summury>
  /// MessageGateway клиент
  /// </summury>
  public class MGCustomer
  {
    /// <summary>
    /// Клиент
    /// </summary>
    public Customer customer { get; set; }

    /// <summary>
    /// Внешний ID MessageGateway клиента
    /// </summary>
    public string externalId { get; set; }

    /// <summary>
    /// Канал
    /// </summary>
    public MGChannel channel { get; set; }

    /// <summary>
    /// Диалоги
    /// </summary>
    public MGDialog[] dialogs { get; set; }

  }
}