namespace RetailCRMCore.Models
{

  public class Site
  {

    /// <summary>
    /// ID
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// URL магазина
    /// </summary>
    public string url { get; set; }

    /// <summary>
    /// Комментарий
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// Статус активности
    /// </summary>
    public bool active { get; set; }

    /// <summary>
    /// Устанавливается по-умолчанию для заказов, создаваемых в системе
    /// </summary>
    public string defaultForCrm { get; set; }

    /// <summary>
    /// Порядок
    /// </summary>
    public string ordering { get; set; }

    /// <summary>
    /// deprecated Юридическое лицо. Используйте LegalEntity.legalName
    /// </summary>
    public LegalEntity legalEntity { get; set; }

    /// <summary>
    /// deprecated ИНН. Используйте LegalEntity.INN
    /// </summary>
    public string inn { get; set; }

    /// <summary>
    /// deprecated Расчетный счет. Используйте LegalEntity.bankAccount
    /// </summary>
    public string giro { get; set; }

    /// <summary>
    /// deprecated Корреспондентский счет. Используйте LegalEntity.corrAccount
    /// </summary>
    public string corrAccount { get; set; }

    /// <summary>
    /// Телефоны магазина
    /// </summary>
    public string phones { get; set; }

    /// <summary>
    /// Адрес магазина
    /// </summary>
    public string address { get; set; }

    /// <summary>
    /// Почтовый индекс
    /// </summary>
    public string zip { get; set; }

    /// <summary>
    /// Дата создания магазина в системе
    /// </summary>
    public DateTime createdAt { get; set; }

    /// <summary>
    /// Символьный код магазина
    /// </summary>
    public string code { get; set; }

    /// <summary>
    /// Юридическое лицо
    /// </summary>
    public LegalEntity contragent { get; set; }

    /// <summary>
    /// Страна по умолчанию
    /// </summary>
    public string country { get; set; }

  }
}