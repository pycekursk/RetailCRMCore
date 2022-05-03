namespace RetailCRMCore.Models
{
  /// <summury>
  /// Торговое предложение или товарная группа
  /// </summury>
  public class CatalogItem
  {

    /// <summary>
    /// Торговое предложение
    /// </summary>
    public Offer offer { get; set; }

    /// <summary>
    /// Товарная группа
    /// </summary>
    public ProductGroup productGroup { get; set; }

  }
}