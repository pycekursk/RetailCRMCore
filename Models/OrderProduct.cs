namespace RetailCRMCore.Models
{
  public class OrderProduct
  {
    public double discountManualAmount { get; set; }
    public double discountManualPercent { get; set; }
    public string[] markingCodes { get; set; }

    public ExternalId[] externalIds { get; set; }
    public string externalId { get; set; }
    public string comment { get; set; }
    public Properties[] properties { get; set; }
    public Offer offer { get; set; }
    public double purchasePrice { get; set; }
    public int id { get; set; }
    public double initialPrice { get; set; }
    public PriceType priceType { get; set; }

    public double discountTotal { get; set; }
    //public Price[] prices { get; set; }
    public string vatRate { get; set; }
    public string createdAt { get; set; }
    public float quantity { get; set; }
    public string status { get; set; }


    public string productId { get; set; }
    public string productName { get; set; }
        public double summ { get; set; }
    }
}