using Newtonsoft.Json;

using RetailCRMCore.Models;

using System.Text.Json;

namespace RetailCRMCore.Helpers

{
  public class ArrayNamingProlicy<T> : JsonNamingPolicy
  {
    public override string ConvertName(string name)
    {
      string result = string.Empty;


      result = name == "Array" ? $"{typeof(T).Name.ToLower()}s" : name == "productGroups" ? "productGroup" : name.ToLower();

      return result;
    }
  }

  //public class JsonConverter<T> : JsonConverter
  //{
  //  public override string ConvertName(string name)
  //  {
  //    string result = string.Empty;

  //    var type = typeof(T);

  //    if (name == "payments")
  //    {

  //    }

  //    result = name == "Array" ? $"{typeof(T).Name.ToLower()}s" : name == "productGroups" ? "productGroup" : name.ToLower();
  //    return result;
  //  }
  // }
}