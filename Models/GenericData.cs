namespace RetailCRMCore.Models
{
  public class GenericData
  {
    public string externalId { get; set; }
    public string trackNumber { get; set; }

    public bool locked { get; set; }
    public string tariff { get; set; }
    public string pickuppointId { get; set; }

    public string payerType { get; set; }
    public string shipmentpointId { get; set; }
    public object[] extraData { get; set; }
    public Package[] packages { get; set; }
  }
}