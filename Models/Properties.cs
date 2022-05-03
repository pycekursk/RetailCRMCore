namespace RetailCRMCore.Models
{
  public class Properties
  {
    public Property[] properties { get; set; }
  }

  //public class Property
  //{
  //  public string? code { get; set; }
  //  public string? name { get; set; }
  //  public bool isNumeric { get; set; }
  //  public bool visible { get; set; }
  //  public bool variative { get; set; }
  //}

  public class Property
  {
    public string? name { get; set; }
    public string? value { get; set; }
  }
}