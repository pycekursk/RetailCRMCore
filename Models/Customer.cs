namespace RetailCRMCore.Models
{

  public enum SexCode
  {
    male,
    female,
    @null = 0
  }


  /// <summury>
  /// Клиент
  /// </summury>
  public class Customer
  {
    /// <summary>
    /// Тип клиента (customer - клиент, customer_corporate - корпоративный клиент)
    /// </summary>
    public string typeCode { get; set; }

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
    /// Пол ("male", "female" или null)
    /// </summary>
    public SexCode sexCode { get; set; }

    /// <summary>
    /// Предположительный пол на основе ФИО
    /// </summary>
    public string presumableSexCode { get; set; }

    /// <summary>
    /// E-mail
    /// </summary>
    public string email { get; set; }

    /// <summary>
    /// Любой найденый e-mail
    /// </summary>
    public string anyEmail { get; set; }

    /// <summary>
    /// День рождения
    /// </summary>
    public string birthday { get; set; }

    /// <summary>
    /// Источник клиента
    /// </summary>
    public Source source { get; set; }

    /// <summary>
    /// Телефоны
    /// </summary>
    public Phone[] phones { get; set; }

    /// <summary>
    /// Последний указанный телефон
    /// </summary>
    public string lastPhone { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string phone { get; set; }

    /// <summary>
    /// Любой найденый телефон
    /// </summary>
    public string anyPhone { get; set; }

    /// <summary>
    /// Клиенты MessageGateway
    /// </summary>
    public MGCustomer[] mgCustomers { get; set; }

    /// <summary>
    /// Адрес клиента
    /// </summary>
    public Address address { get; set; }

    /// <summary>
    /// deprecated Комментарий
    /// </summary>
    public string commentary { get; set; }

    /// <summary>
    /// [массив] Сегменты
    /// </summary>
    public Segment[] segments { get; set; }

    /// <summary>
    /// Участие в ПЛ клиента по коду сайта
    /// </summary>
    public string loyaltyAccountBySiteCode { get; set; }

    /// <summary>
    /// ID клиента
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Создан
    /// </summary>
    public string createdAt { get; set; }

    /// <summary>
    /// Контактные лица
    /// </summary>
    public object customerContacts { get; set; }

    /// <summary>
    /// Адреса клиента
    /// </summary>
    public Address[] addresses { get; set; }

    /// <summary>
    /// Основной адрес клиента
    /// </summary>
    public object mainAddress { get; set; }

    /// <summary>
    /// Магазин, с которого пришел клиент
    /// </summary>
    public object site { get; set; }

    /// <summary>
    /// Менеджер клиента
    /// </summary>
    public object manager { get; set; }

    /// <summary>
    /// Важный клиент
    /// </summary>
    public bool vip { get; set; }

    /// <summary>
    /// Плохой клиент
    /// </summary>
    public bool bad { get; set; }

    /// <summary>
    /// Внешний ID клиента
    /// </summary>
    public string externalId { get; set; }

    /// <summary>
    /// deprecated Реквизиты (Поля объекта следует использовать только при неактивированной функциональности "Корпоративные клиенты")
    /// </summary>
    public object contragent { get; set; }

    /// <summary>
    /// Дата отписки от email рассылок
    /// </summary>
    public DateTime emailMarketingUnsubscribedAt { get; set; }

    /// <summary>
    /// Заметки
    /// </summary>
    public object notes { get; set; }

    /// <summary>
    /// Основное контактное лицо
    /// </summary>
    public object mainCustomerContact { get; set; }

    /// <summary>
    /// [массив] Теги
    /// </summary>
    public CustomerTag[] tags { get; set; }

    /// <summary>
    /// Проверить есть ли тег у клиента
    /// </summary>
    public bool hasTag { get; set; }

    /// <summary>
    /// Прикрепленные объекты (вложения)
    /// </summary>
    public object attachments { get; set; }

    /// <summary>
    /// Возраст
    /// </summary>
    public object ageType { get; set; }

    /// <summary>
    /// Первый визит клиента на сайт
    /// </summary>
    public object firstWebVisit { get; set; }

    /// <summary>
    /// Последний визит клиента на сайт
    /// </summary>
    public object lastWebVisit { get; set; }

    /// <summary>
    /// Уникальные метки Google Analytics
    /// </summary>
    public object clientIds { get; set; }

    /// <summary>
    /// deprecated Уникальные метки Google Analytics
    /// </summary>
    public string utma { get; set; }

    /// <summary>
    /// Первая метка клиента Google Analytics
    /// </summary>
    public string firstClientId { get; set; }

    /// <summary>
    /// Последняя метка клиента Google Analytics
    /// </summary>
    public string lastClientId { get; set; }

    /// <summary>
    /// Ассоциативный массив пользовательских полей
    /// </summary>
    public object[] customFields { get; set; }

    /// <summary>
    /// Возвращает значение пользовательского поля. В code указывается символьный код поля.
    /// </summary>
    public object customField { get; set; }

    /// <summary>
    /// Общая сумма заказов
    /// </summary>
    public double totalSumm { get; set; }

    /// <summary>
    /// Средняя сумма заказа
    /// </summary>
    public double averageSumm { get; set; }

    /// <summary>
    /// Количество заказов
    /// </summary>
    public int ordersCount { get; set; }

    /// <summary>
    /// Первый неотмененный заказ клиента
    /// </summary>
    public Order firstOrder { get; set; }

    /// <summary>
    /// Последний неотмененный заказ клиента
    /// </summary>
    public Order lastOrder { get; set; }

    /// <summary>
    /// Monetary-сегмент в RFM
    /// </summary>
    public string monetaryClass { get; set; }

    /// <summary>
    /// Frequency-сегмент в RFM
    /// </summary>
    public string frequencyClass { get; set; }

    /// <summary>
    /// Recency-сегмент в RFM
    /// </summary>
    public string recencyClass { get; set; }

    /// <summary>
    /// Расчетное значение Monetary в RFM
    /// </summary>
    public string monetaryValue { get; set; }

    /// <summary>
    /// Расчетное значение Recency в RFM
    /// </summary>
    public string recencyValue { get; set; }

    /// <summary>
    /// Средняя валовая прибыль по заказам клиента
    /// </summary>
    public double avgMarginSumm { get; set; }

    /// <summary>
    /// Среднее время между заказами, в секундах
    /// </summary>
    public string avgSecondsBetweenOrders { get; set; }

    /// <summary>
    /// LTV
    /// </summary>
    public double marginSumm { get; set; }

    /// <summary>
    /// deprecated Накопительная скидка (Недоступно, начиная с 8 версии системы)
    /// </summary>
    public double cumulativeDiscount { get; set; }

    /// <summary>
    /// Персональная скидка
    /// </summary>
    public double personalDiscount { get; set; }

    /// <summary>
    /// Номер дисконтной карты
    /// </summary>
    public string discountCardNumber { get; set; }

    /// <summary>
    /// Время «созревания», в секундах
    /// </summary>
    public int maturationTime { get; set; }

  }


  public class CustomerTag
  {
    /// <summary>
    /// Название тега
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Цвет тега
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// Признак прикреплённости тега
    /// </summary>
    public bool attached { get; set; }
  }

  public class Segment
  {
    /// <summary>
    /// Внутренний ID сегмента
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Название сегмента
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Дата создания сегмента
    /// </summary>
    public string createdAt { get; set; }

    /// <summary>
    /// Символьный код
    /// </summary>
    public string code { get; set; }

    /// <summary>
    /// Является ли сегмент автоматически пересчитываемым
    /// </summary>
    public bool isDynamic { get; set; }

    /// <summary>
    /// Количество клиентов в сегменте
    /// </summary>
    public int customersCount { get; set; }
  }
}