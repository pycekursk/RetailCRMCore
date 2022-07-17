namespace RetailCRMCore.Models
{
    ///// <summury>
    ///// Тип доставки
    ///// </summury>
    //public class DeliveryType
    //{
    //  /// <summary>
    //  /// Название
    //  /// </summary>
    //  public string name { get; set; }

    //  /// <summary>
    //  /// Символьный код
    //  /// </summary>
    //  public string code { get; set; }

    //  /// <summary>
    //  /// Статус активности
    //  /// </summary>
    //  public bool active { get; set; }


    //  public bool isDynamicCostCalculation { get; set; }
    //  public bool isAutoCostCalculation { get; set; }
    //  public bool isAutoNetCostCalculation { get; set; }
    //  public bool isCostDependsOnRegionAndWeightAndSum { get; set; }
    //  public bool isCostDependsOnDateTime { get; set; }

    //  /// <summary>
    //  /// Стоимость по-умолчанию
    //  /// </summary>
    //  public double defaultCost { get; set; }

    //  /// <summary>
    //  /// Себестоимость по-умолчанию
    //  /// </summary>
    //  public double defaultNetCost { get; set; }

    //  /// <summary>
    //  /// Комментарий
    //  /// </summary>
    //  public string? description { get; set; }

    //  public string? integrationCode { get; set; }

    //  /// <summary>
    //  /// Разрешенные типы оплат
    //  /// </summary>
    //  public string[] paymentTypes { get; set; }

    //  /// <summary>
    //  /// Службы доставок, которые входят в данный тип доставки
    //  /// </summary>
    //  public DeliveryService[] deliveryServices { get; set; }

    //  /// <summary>
    //  /// Устанавливается по-умолчанию для заказов, создаваемых в системе
    //  /// </summary>
    //  public bool defaultForCrm { get; set; }
    //}



    public class DeliveryType
    {
        //public bool isDynamicCostCalculation { get; set; }
        //public bool isAutoCostCalculation { get; set; }
        //public bool isAutoNetCostCalculation { get; set; }
        //public bool isCostDependsOnRegionAndWeightAndSum { get; set; }
        //public bool isCostDependsOnDateTime { get; set; }

        public string name { get; set; }
        public string code { get; set; }
        public bool active { get; set; }
        public int defaultCost { get; set; }
        public int defaultNetCost { get; set; }
        public string description { get; set; }
        public string[] paymentTypes { get; set; }
        //public string integrationCode { get; set; }
        public DeliveryService[] deliveryServices { get; set; }
        public bool defaultForCrm { get; set; }
        //public bool HasTariffs { get; set; }
    }



    //public class DeliveryType
    //{
    //  public string code { get; set; }
    //  public string integrationCode { get; set; }
    //  public Data data { get; set; }
    //  public int cost { get; set; }
    //  public int netCost { get; set; }
    //  public Address address { get; set; }
    //  public string name { get; set; }
    //}

    //public class Data
    //{
    //  public bool locked { get; set; }
    //  public string payerType { get; set; }
    //  public object[] services { get; set; }
    //  public object[] packages { get; set; }
    //}


}