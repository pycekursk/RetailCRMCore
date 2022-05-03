namespace RetailCRMCore.Models
{
  public class Package
  {
    public string packageId { get; set; }
    public double weight { get; set; }
    public int length { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public PackageItem[] items { get; set; }
  }
}