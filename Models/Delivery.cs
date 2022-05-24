namespace RetailCRMCore.Models
{
  public class Delivery
  {
    public string code { get; set; }
    public double cost { get; set; }
    public double netCost { get; set; }
    public string date { get; set; }
    public string vatRate { get; set; }
    public Address address { get; set; }
    public TimeInterval time { get; set; }
    public DeliveryService service { get; set; }
    public object data { get; set; }
  }
}