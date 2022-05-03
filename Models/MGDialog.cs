namespace RetailCRMCore.Models
{
  /// <summury>
  /// MessageGateway Диалог
  /// </summury>
  public class MGDialog
  {
    /// <summary>
    /// Внешний ID диалога
    /// </summary>
    public string externalId { get; set; }

    /// <summary>
    /// Дата создания диалога
    /// </summary>
    public DateTime createdAt { get; set; }

    /// <summary>
    /// Дата закрытия диалога
    /// </summary>
    public DateTime closedAt { get; set; }

    /// <summary>
    /// MessageGateway Клиент
    /// </summary>
    public MGCustomer mgCustomer { get; set; }

    /// <summary>
    /// Пользователь
    /// </summary>
    public User manager { get; set; }

    /// <summary>
    /// MessageGateway Бот
    /// </summary>
    public MGBot mgBot { get; set; }

    /// <summary>
    /// Количество сообщений от клиента
    /// </summary>
    public string messagesFromCustomer { get; set; }

    /// <summary>
    /// Количество сообщений от менеджеров
    /// </summary>
    public string messagesFromManagers { get; set; }

  }
}