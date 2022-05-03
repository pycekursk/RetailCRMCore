using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailCRMCore.Models
{
  public class Source
  {
    public int id { get; set; }
    public string sourceName { get; set; }
    public string mediumName { get; set; }
    public string campaignName { get; set; }
    public string keywordName { get; set; }
    public string adContentName { get; set; }
  }
}
