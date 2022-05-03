namespace RetailCRMCore.Models
{
  public class Pagination
  {
    public int limit { get; set; }
    public int totalCount { get; set; }
    public int currentPage { get; set; }
    public int totalPageCount { get; set; }
  }
}