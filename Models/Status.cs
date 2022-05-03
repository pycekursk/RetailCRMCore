namespace RetailCRMCore.Models
{
  /// <summury>
  /// Статус заказа
  /// </summury>
  public class Status
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
    /// Порядок
    /// </summary>
    public string ordering { get; set; }

    /// <summary>
    /// Группа статусов, к которой относится статус
    /// </summary>
    public StatusGroup group { get; set; }

    /// <summary>
    /// Символьный код группы статусов, к которой относится статус
    /// </summary>
    public string groupCode { get; set; }

  }
}