namespace RetailCRMCore.Models
{
  /// <summury>
  /// Пользователь
  /// </summury>
  public class User
  {
    /// <summary>
    /// ID пользователя
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public bool active { get; set; }

    /// <summary>
    /// Email пользователя
    /// </summary>
    public string email { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string firstName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string lastName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string patronymic { get; set; }

    /// <summary>
    /// ФИО
    /// </summary>
    public string nickName { get; set; }

    /// <summary>
    /// Имя Фамилия
    /// </summary>
    public string cutName { get; set; }

    /// <summary>
    /// Пользователь является менеджером, обрабатывающим заказы
    /// </summary>
    public bool isManager { get; set; }

    /// <summary>
    /// Является администратором
    /// </summary>
    public bool isAdmin { get; set; }

    /// <summary>
    /// Пользователь отвечает за доставку
    /// </summary>
    public bool isDeliveryMan { get; set; }

    /// <summary>
    /// Доступ пользователя к заказа ограничен по типам доставок
    /// </summary>
    public string restrictedByDeliveryTypes { get; set; }

    /// <summary>
    /// Перечень типов доставок, которые разрешают пользователю просмотр заказов, если включен флаг ограничения заказов по доставкам restrictedByDeliveryTypes. При использовании обязательно проверяйте, что restrictedByDeliveryTypes имеет значение true
    /// </summary>
    public string allowedDeliveryTypes { get; set; }

    /// <summary>
    /// deprecated Используйте allowedDeliveryTypes. Перечень типов доставок, которые разрешают пользователю просмотр заказов, если включен флаг ограничения заказов по доставкам restrictedByDeliveryTypes. При использовании обязательно проверяйте, что restrictedByDeliveryTypes имеет значение true
    /// </summary>
    public string restrictingDeliveryTypes { get; set; }

    /// <summary>
    /// Символьные коды групп пользователя
    /// </summary>
    public string groupCodes { get; set; }

    /// <summary>
    /// Проверка, входит ли пользователь в указанную группу
    /// </summary>
    public string hasGroup { get; set; }

    /// <summary>
    /// Должность
    /// </summary>
    public string position { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string phone { get; set; }

    /// <summary>
    /// Телефон для аутентификации
    /// </summary>
    public string phoneTfa { get; set; }

    /// <summary>
    /// Дата создания пользователя
    /// </summary>
    public string createdAt { get; set; }

    /// <summary>
    /// Количество заказов на менеджере
    /// </summary>
    public string ordersCount { get; set; }

    /// <summary>
    /// Количество клиентов на менеджере
    /// </summary>
    public string customersCount { get; set; }

    /// <summary>
    /// Общая сумма заказов на менеджере
    /// </summary>
    public string totalSaleSumm { get; set; }

    /// <summary>
    /// Средний чек заказов на менеджере
    /// </summary>
    public string avgSaleSumm { get; set; }

    /// <summary>
    /// Общая маржа заказов на менеджере
    /// </summary>
    public string marginSumm { get; set; }

    /// <summary>
    /// Средняя маржа заказов на менеджере
    /// </summary>
    public string avgMarginSumm { get; set; }

  }
}