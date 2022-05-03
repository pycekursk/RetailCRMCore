using Newtonsoft.Json;

namespace RetailCRMCore.Models
{

  public class TimeInterval
  {
    public DateTime from { get; set; }
    public DateTime to { get; set; }
    public string custom { get; set; }
    [JsonProperty("string")]
    public string stringDateTime { get; set; }
    public bool isEmpty { get; set; }
  }
}