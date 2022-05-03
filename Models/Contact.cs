namespace RetailCRMCore.Models
{
  public class Contact
  {
    public string type { get; set; }
    public int id { get; set; }
    public bool isContact { get; set; }
    public string createdAt { get; set; }
    public bool vip { get; set; }
    public bool bad { get; set; }
    public string site { get; set; }
    public Contragent contragent { get; set; }
    public object[] tags { get; set; }
    public object[] customFields { get; set; }
    public double marginSumm { get; set; }
    public double totalSumm { get; set; }
    public double averageSumm { get; set; }
    public double ordersCount { get; set; }
    public double costSumm { get; set; }
    public double personalDiscount { get; set; }
    public object[] segments { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public Phone[] phones { get; set; }
  }
}