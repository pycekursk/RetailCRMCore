namespace RetailCRMCore.Models
{
  /// <summury>
  /// Группа статусов
  /// </summury>
  public class StatusGroup
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
    /// Является или нет процессным состоянием заказа
    /// </summary>
    public string process { get; set; }

    /// <summary>
    /// Признак того, что группа добавлена пользователем
    /// </summary>
    public string custom { get; set; }

    /// <summary>
    /// Возможно ли редактирование группы
    /// </summary>
    public string editable { get; set; }

    /// <summary>
    /// Статусы заказов, которые входят в данную группу
    /// </summary>
    public Status[] statuses { get; set; }

    /// <summary>
    /// [массив] Символьные коды статусов заказов, которые входят в данную группу
    /// </summary>
    public string statusesCode { get; set; }

    /// <summary>
    /// Цвет используемый при выводе группы
    /// </summary>
    public string color { get; set; }

  }
}