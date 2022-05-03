namespace RetailCRMCore.Models
{
  /// <summury>
  /// Расход
  /// </summury>
  public class Cost
  {
    /// <summary>
    /// Символьный код статьи расходов
    /// </summary>
    public string costItemCode { get; set; }

    /// <summary>
    /// Название статьи расходов
    /// </summary>
    public string costItemName { get; set; }

    /// <summary>
    /// Название группы расходов
    /// </summary>
    public string costGroupName { get; set; }

    /// <summary>
    /// Символьный код группы расходов
    /// </summary>
    public string costGroupCode { get; set; }

    /// <summary>
    /// Дата (от)
    /// </summary>
    public DateTime dateFrom { get; set; }

    /// <summary>
    /// Дата (до)
    /// </summary>
    public DateTime dateTo { get; set; }

    /// <summary>
    /// Сумма
    /// </summary>
    public string summ { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
    public string comment { get; set; }

  }
}